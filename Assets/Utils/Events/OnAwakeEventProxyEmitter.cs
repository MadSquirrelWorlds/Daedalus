using System;
using UnityEngine;
using UnityEngine.Events;

namespace Utils.Events.Datatyped_Events
{
    public class OnAwakeEventProxyEmitter : MonoBehaviour
    {
        public UnityEvent OnAwake = new UnityEvent();


        private void Awake()
        {
            OnAwake?.Invoke();
        }
    }
}