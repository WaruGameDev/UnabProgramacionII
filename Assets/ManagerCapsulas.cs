using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ManagerCapsulas : MonoBehaviour
{
    public static ManagerCapsulas instance;
    public System.Action onCallCapsules;

    private void Awake()
    {
        instance = this;
    }
   
    public void CallCapsules()
    {
        onCallCapsules?.Invoke();
    }
}
