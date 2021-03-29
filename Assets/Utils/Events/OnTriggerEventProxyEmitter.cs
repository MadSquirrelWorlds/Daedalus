using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterEventProxyEmitter : MonoBehaviour
{
   public UnityEvent OnTriggerEnterEvent = new UnityEvent();
   public void OnTriggerEnter(Collider other)
   {
      OnTriggerEnterEvent?.Invoke();
      //print("triggered");
   }
}
