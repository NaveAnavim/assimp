/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiVector2D : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiVector2D(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiVector2D obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiVector2D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiVector2D(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiVector2D() : this(AssimpPINVOKE.new_aiVector2D__SWIG_0(), true) {
  }

  public aiVector2D(float _x, float _y) : this(AssimpPINVOKE.new_aiVector2D__SWIG_1(_x, _y), true) {
  }

  public aiVector2D(float _xyz) : this(AssimpPINVOKE.new_aiVector2D__SWIG_2(_xyz), true) {
  }

  public aiVector2D(aiVector2D o) : this(AssimpPINVOKE.new_aiVector2D__SWIG_3(aiVector2D.getCPtr(o)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(float pX, float pY) {
    AssimpPINVOKE.aiVector2D_Set(swigCPtr, pX, pY);
  }

  public float SquareLength() {
    float ret = AssimpPINVOKE.aiVector2D_SquareLength(swigCPtr);
    return ret;
  }

  public float Length() {
    float ret = AssimpPINVOKE.aiVector2D_Length(swigCPtr);
    return ret;
  }

  public aiVector2D Normalize() {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D_Normalize(swigCPtr), false);
    return ret;
  }

  public aiVector2D __addnset__(aiVector2D o) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D___addnset__(swigCPtr, aiVector2D.getCPtr(o)), false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D __subnset__(aiVector2D o) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D___subnset__(swigCPtr, aiVector2D.getCPtr(o)), false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D __mulnset__(float f) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D___mulnset__(swigCPtr, f), false);
    return ret;
  }

  public aiVector2D __divnset__(float f) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D___divnset__(swigCPtr, f), false);
    return ret;
  }

  public float __idx__(uint i) {
    float ret = AssimpPINVOKE.aiVector2D___idx____SWIG_0(swigCPtr, i);
    return ret;
  }

  public bool __equal__(aiVector2D other) {
    bool ret = AssimpPINVOKE.aiVector2D___equal__(swigCPtr, aiVector2D.getCPtr(other));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __nequal__(aiVector2D other) {
    bool ret = AssimpPINVOKE.aiVector2D___nequal__(swigCPtr, aiVector2D.getCPtr(other));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D __set__(float f) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D___set__(swigCPtr, f), false);
    return ret;
  }

  public aiVector2D SymMul(aiVector2D o) {
    aiVector2D ret = new aiVector2D(AssimpPINVOKE.aiVector2D_SymMul(swigCPtr, aiVector2D.getCPtr(o)), true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float x {
    set {
      AssimpPINVOKE.aiVector2D_x_set(swigCPtr, value);
    } 
    get {
      float ret = AssimpPINVOKE.aiVector2D_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      AssimpPINVOKE.aiVector2D_y_set(swigCPtr, value);
    } 
    get {
      float ret = AssimpPINVOKE.aiVector2D_y_get(swigCPtr);
      return ret;
    } 
  }

}
