//
//  PhoneHistTableViewController.m
//  PropertyManage
//
//  Created by Momo on 16/6/15.
//  Copyright © 2016年 Momo. All rights reserved.
//

#import "PhoneHistTableViewController.h"
#import "ContactModel.h"
#import "RecentTableViewCell.h"

@interface PhoneHistTableViewController (Private)

-(void) refreshData;
-(void) refreshDataAndReload;
-(void) onHistoryEvent:(NSNotification*)notification;

@end

@implementation PhoneHistTableViewController(Private)

-(void) refreshData{
    @synchronized(mEvents){
        [mEvents removeAllObjects];
        NSArray* events = [[[mHistoryService events] allValues] sortedArrayUsingSelector:@selector(compareHistoryEventByDateASC:)];
        for (NgnHistoryEvent* event in events) {
            
//            if (!event) {
//                continue;
//            }
//            if (!(event.mediaType & MediaType_AudioVideo)) {
//                continue;
//            }
//            if (!(event.status & mStatusFilter)) {
//                continue;
//            }
            
            if(!event || !(event.mediaType & MediaType_AudioVideo) || !(event.status & mStatusFilter)){
                continue;
            }
            [mEvents addObject:event];
            
            // 去联系人数据库中获取
            
        }
        //结束刷新
        [self endRefresh];
        if (mEvents.count == 0) {
            if (![[NSUserDefaults standardUserDefaults] boolForKey:@"isFirstGet"]) {
//                [SVProgressHUD showErrorWithStatus:@"没有数据"];
            }
            else{
                [[NSUserDefaults standardUserDefaults]setBool:NO forKey:@"isFirstGet"];
            }
        }
        else{
            [self.tableView reloadData];
        }
        
        SYLog(@"通话记录 ==== %@",mEvents);
    }
}

-(void) refreshDataAndReload{
    
    if ([NSThread isMainThread])
    {
        [self refreshData];
        [self.tableView reloadData];
    }
    else
    {
        dispatch_sync(dispatch_get_main_queue(), ^{
            //Update UI in UI thread here
            [self refreshData];
            [self.tableView reloadData];
            
        });
    }
}

-(void) onHistoryEvent:(NSNotification*)notification{
    NgnHistoryEventArgs* eargs = [notification object];
    
    switch (eargs.eventType) {
        case HISTORY_EVENT_ITEM_ADDED:
        {
            if((eargs.mediaType & MediaType_AudioVideo)){
                NgnHistoryEvent* event = [[mHistoryService events] objectForKey: [NSNumber numberWithLongLong: eargs.eventId]];
                if(event){
                    [mEvents insertObject:event atIndex:0];
                    [self.tableView reloadData];
                }
            }
            break;
        }
            
        case HISTORY_EVENT_ITEM_MOVED:
        case HISTORY_EVENT_ITEM_UPDATED:
        {
            [self.tableView reloadData];
            break;
        }
            
        case HISTORY_EVENT_ITEM_REMOVED:
        {
            if((eargs.mediaType & MediaType_AudioVideo)){
                for (NgnHistoryEvent* event in mEvents) {
                    if(event.id == eargs.eventId){
                        [mEvents removeObject: event];
                        [self.tableView reloadData];
                        break;
                    }
                }
            }
            break;
        }
            
        case HISTORY_EVENT_RESET:
             [[NgnEngine sharedInstance].historyService deleteEventWithId:eargs.eventId];
        default:
        {
            [self refreshDataAndReload];
            break;
        }
    }
}

@end

@interface PhoneHistTableViewController ()




@end

@implementation PhoneHistTableViewController


- (void)viewWillAppear:(BOOL)animated{
    [super viewWillAppear:animated];
    [self cheakDataCount:mEvents];
}


- (void)viewDidLoad {
    [super viewDidLoad];
    [[NSUserDefaults standardUserDefaults]setBool:YES forKey:@"isFirstGet"];
    
    [[NgnEngine sharedInstance].historyService load];
    
    if(!mEvents){
        mEvents = [[NgnHistoryEventMutableArray alloc] init];
    }
    mStatusFilter = HistoryEventStatus_All;
    
    // get contact service instance
    mContactService = [NgnEngine sharedInstance].contactService;
    mHistoryService = [NgnEngine sharedInstance].historyService;
    
    // refresh data
    [self refreshData];
    
    [self cheakDataCount:mEvents];
    
    self.navigationItem.title = @"History";
    
    self.tableView.delegate = self;
    self.tableView.dataSource = self;
    
    [[NSNotificationCenter defaultCenter]
     addObserver:self selector:@selector(onHistoryEvent:) name:kNgnHistoryEventArgs_Name object:nil];
}

// 下拉刷新实现
-(void)getDataFromNetWork{
    // refresh data
    [self refreshData];
}


//
//	UITableViewDelegate
//

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    @synchronized(mEvents){
        return [mEvents count];
    }
}
- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    static NSString * identify = @"RecentCell";
    RecentTableViewCell *cell=[tableView dequeueReusableCellWithIdentifier:identify];
    if (cell==nil) {
        cell=[[RecentTableViewCell alloc]initWithStyle:UITableViewCellStyleDefault reuseIdentifier:identify];
        cell.accessoryType = UITableViewCellAccessoryDisclosureIndicator;
    }
    [cell setSelectionStyle:UITableViewCellSelectionStyleNone];
    
    
    @synchronized(mEvents){
        NgnHistoryEvent* event;
        if (indexPath.row >= mEvents.count) {
            event = [mEvents lastObject];
        }
        else{
            event = [mEvents objectAtIndex: indexPath.row];
        }
        
        [cell setEvent:event];
        
        ContactModel * model = [PMSipTools gainContactModelFromSipNum:event.remoteParty];
        if (model) {
            [cell setContactModel:model];
        }
    }
    
    return cell;
}


- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath {
    @synchronized(mEvents){
        NgnHistoryEvent* event = [mEvents objectAtIndex: indexPath.row];
        if (event) {
            //通过sip去数据库获取一个联系人
            //获取到联系人 跳转到联系人详情页
            ContactModel * model = [PMSipTools gainContactModelFromSipNum:event.remoteParty];
            if (model) {
               
                [[Routable sharedRouter] open:OWNER_VIEWCONTROLLER animated:YES extraParams:@{@"isOwner":@(NO),@"contactModel":model}];
            }
            else{
                [SVProgressHUD showErrorWithStatus:@"未查询到该联系人相关信息"];
            }
            
        
        }
    }
}
@end
