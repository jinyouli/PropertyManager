/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class CallSession : InviteSession {
  private HandleRef swigCPtr;

  internal CallSession(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.CallSession_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CallSession obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CallSession() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_CallSession(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CallSession(SipStack pStack) : this(tinyWRAPPINVOKE.new_CallSession(SipStack.getCPtr(pStack)), true) {
  }

  public bool callAudio(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudio(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callAudio(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudio(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool callAudioVideo(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudioVideo(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callAudioVideo(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudioVideo(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool callVideo(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callVideo(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callVideo(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callVideo(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool call(string remoteUriString, twrap_media_type_t media, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_call__SWIG_0(swigCPtr, remoteUriString, (int)media, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool call(string remoteUriString, twrap_media_type_t media) {
    bool ret = tinyWRAPPINVOKE.CallSession_call__SWIG_1(swigCPtr, remoteUriString, (int)media);
    return ret;
  }

  public bool call(SipUri remoteUri, twrap_media_type_t media, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_call__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), (int)media, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool call(SipUri remoteUri, twrap_media_type_t media) {
    bool ret = tinyWRAPPINVOKE.CallSession_call__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri), (int)media);
    return ret;
  }

  public bool setSessionTimer(uint timeout, string refresher) {
    bool ret = tinyWRAPPINVOKE.CallSession_setSessionTimer(swigCPtr, timeout, refresher);
    return ret;
  }

  public bool set100rel(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_set100rel(swigCPtr, enabled);
    return ret;
  }

  public bool setRtcp(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setRtcp(swigCPtr, enabled);
    return ret;
  }

  public bool setRtcpMux(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setRtcpMux(swigCPtr, enabled);
    return ret;
  }

  public bool setSRtpMode(tmedia_srtp_mode_t mode) {
    bool ret = tinyWRAPPINVOKE.CallSession_setSRtpMode(swigCPtr, (int)mode);
    return ret;
  }

  public bool setAvpfMode(tmedia_mode_t mode) {
    bool ret = tinyWRAPPINVOKE.CallSession_setAvpfMode(swigCPtr, (int)mode);
    return ret;
  }

  public bool setICE(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setICE(swigCPtr, enabled);
    return ret;
  }

  public bool setICEStun(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setICEStun(swigCPtr, enabled);
    return ret;
  }

  public bool setICETurn(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setICETurn(swigCPtr, enabled);
    return ret;
  }

  public bool setSTUNServer(string hostname, ushort port) {
    bool ret = tinyWRAPPINVOKE.CallSession_setSTUNServer(swigCPtr, hostname, port);
    return ret;
  }

  public bool setSTUNCred(string username, string password) {
    bool ret = tinyWRAPPINVOKE.CallSession_setSTUNCred(swigCPtr, username, password);
    return ret;
  }

  public bool setVideoFps(int fps) {
    bool ret = tinyWRAPPINVOKE.CallSession_setVideoFps(swigCPtr, fps);
    return ret;
  }

  public bool setVideoBandwidthUploadMax(int max) {
    bool ret = tinyWRAPPINVOKE.CallSession_setVideoBandwidthUploadMax(swigCPtr, max);
    return ret;
  }

  public bool setVideoBandwidthDownloadMax(int max) {
    bool ret = tinyWRAPPINVOKE.CallSession_setVideoBandwidthDownloadMax(swigCPtr, max);
    return ret;
  }

  public bool setVideoPrefSize(tmedia_pref_video_size_t pref_video_size) {
    bool ret = tinyWRAPPINVOKE.CallSession_setVideoPrefSize(swigCPtr, (int)pref_video_size);
    return ret;
  }

  public bool setQoS(tmedia_qos_stype_t type, tmedia_qos_strength_t strength) {
    bool ret = tinyWRAPPINVOKE.CallSession_setQoS(swigCPtr, (int)type, (int)strength);
    return ret;
  }

  public bool hold(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_hold__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool hold() {
    bool ret = tinyWRAPPINVOKE.CallSession_hold__SWIG_1(swigCPtr);
    return ret;
  }

  public bool resume(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_resume__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool resume() {
    bool ret = tinyWRAPPINVOKE.CallSession_resume__SWIG_1(swigCPtr);
    return ret;
  }

  public bool transfer(string referToUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_transfer__SWIG_0(swigCPtr, referToUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool transfer(string referToUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_transfer__SWIG_1(swigCPtr, referToUriString);
    return ret;
  }

  public bool acceptTransfer(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_acceptTransfer__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool acceptTransfer() {
    bool ret = tinyWRAPPINVOKE.CallSession_acceptTransfer__SWIG_1(swigCPtr);
    return ret;
  }

  public bool rejectTransfer(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_rejectTransfer__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool rejectTransfer() {
    bool ret = tinyWRAPPINVOKE.CallSession_rejectTransfer__SWIG_1(swigCPtr);
    return ret;
  }

  public bool sendDTMF(int number) {
    bool ret = tinyWRAPPINVOKE.CallSession_sendDTMF(swigCPtr, number);
    return ret;
  }

  public uint getSessionTransferId() {
    uint ret = tinyWRAPPINVOKE.CallSession_getSessionTransferId(swigCPtr);
    return ret;
  }

  public bool sendT140Data(tmedia_t140_data_type_t data_type, IntPtr data_ptr, uint data_size) {
    bool ret = tinyWRAPPINVOKE.CallSession_sendT140Data__SWIG_0(swigCPtr, (int)data_type, data_ptr, data_size);
    return ret;
  }

  public bool sendT140Data(tmedia_t140_data_type_t data_type, IntPtr data_ptr) {
    bool ret = tinyWRAPPINVOKE.CallSession_sendT140Data__SWIG_1(swigCPtr, (int)data_type, data_ptr);
    return ret;
  }

  public bool sendT140Data(tmedia_t140_data_type_t data_type) {
    bool ret = tinyWRAPPINVOKE.CallSession_sendT140Data__SWIG_2(swigCPtr, (int)data_type);
    return ret;
  }

  public bool setT140Callback(T140Callback pT140Callback) {
    bool ret = tinyWRAPPINVOKE.CallSession_setT140Callback(swigCPtr, T140Callback.getCPtr(pT140Callback));
    return ret;
  }

}

}
