//
//  SystemTableViewCell.h
//  PropertyManage
//
//  Created by Momo on 16/6/15.
//  Copyright © 2016年 Momo. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "PlotModel.h"
@interface SystemTableViewCell : UITableViewCell

@property (nonatomic,strong) PlotModel * model;
-(instancetype)initWithTableview:(UITableView *)tableview;
+(instancetype)cellWithTableview:(UITableView *)tableview;

@end
