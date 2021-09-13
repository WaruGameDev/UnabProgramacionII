using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class OnTriggerEnterChangeCamera : MonoBehaviour
{
   
    public UnityEvent onTriggerEnterEvent, onTriggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            onTriggerEnterEvent?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            onTriggerExitEvent?.Invoke();
        }
    }
}
