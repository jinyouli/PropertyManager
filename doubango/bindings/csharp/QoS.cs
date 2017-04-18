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

public class QoS : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QoS(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(QoS obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~QoS() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_QoS(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float getQavg() {
    float ret = tinyWRAPPINVOKE.QoS_getQavg(swigCPtr);
    return ret;
  }

  public float getQ1() {
    float ret = tinyWRAPPINVOKE.QoS_getQ1(swigCPtr);
    return ret;
  }

  public float getQ2() {
    float ret = tinyWRAPPINVOKE.QoS_getQ2(swigCPtr);
    return ret;
  }

  public float getQ3() {
    float ret = tinyWRAPPINVOKE.QoS_getQ3(swigCPtr);
    return ret;
  }

  public float getQ4() {
    float ret = tinyWRAPPINVOKE.QoS_getQ4(swigCPtr);
    return ret;
  }

  public float getQ5() {
    float ret = tinyWRAPPINVOKE.QoS_getQ5(swigCPtr);
    return ret;
  }

  public uint getVideoInWidth() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoInWidth(swigCPtr);
    return ret;
  }

  public uint getVideoOutWidth() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoOutWidth(swigCPtr);
    return ret;
  }

  public uint getVideoInHeight() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoInHeight(swigCPtr);
    return ret;
  }

  public uint getVideoOutHeight() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoOutHeight(swigCPtr);
    return ret;
  }

  public uint getBandwidthDownKbps() {
    uint ret = tinyWRAPPINVOKE.QoS_getBandwidthDownKbps(swigCPtr);
    return ret;
  }

  public uint getBandwidthUpKbps() {
    uint ret = tinyWRAPPINVOKE.QoS_getBandwidthUpKbps(swigCPtr);
    return ret;
  }

  public uint getVideoInAvgFps() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoInAvgFps(swigCPtr);
    return ret;
  }

  public uint getVideoDecAvgTime() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoDecAvgTime(swigCPtr);
    return ret;
  }

  public uint getVideoEncAvgTime() {
    uint ret = tinyWRAPPINVOKE.QoS_getVideoEncAvgTime(swigCPtr);
    return ret;
  }

}

}
