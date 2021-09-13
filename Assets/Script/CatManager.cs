using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;

public class CatManager : MonoBehaviour
{
    public static CatManager instance;
    public int monedas;
    public Action onGetMoney;
    public TextMeshProUGUI monedasText;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        AddMoney(0);
    }

    public void OnGetMoney()
    {
        onGetMoney?.Invoke();
    }
    public void AddMoney(int i)
    {
        monedas += i;
        OnGetMoney();
        monedasText.text = monedas.ToString();
    }


}
