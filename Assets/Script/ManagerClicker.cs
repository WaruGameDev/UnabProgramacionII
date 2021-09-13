using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using TMPro;

public class ManagerClicker : MonoBehaviour
{
    public static ManagerClicker instance;
    public Action onLevelUp;
    public int cantidadDeClicks;
    public TextMeshProUGUI clicks;


    private void Awake()
    {
        instance = this;
    }   

    public void OnLevelUP()
    {
        onLevelUp?.Invoke();
        clicks.text = cantidadDeClicks.ToString();
    }


}
