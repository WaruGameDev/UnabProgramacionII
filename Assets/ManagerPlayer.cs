using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerPlayer : MonoBehaviour
{
    public static ManagerPlayer instance;
    public System.Action onCallPlayer;
    private void Awake()
    {
        instance = this;
    }
    public void CallPlayer()
    {
        onCallPlayer?.Invoke();
    }
    
}
