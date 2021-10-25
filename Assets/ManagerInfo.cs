using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerInfo : MonoBehaviour
{
    public static ManagerInfo instance;
    public TextMeshProUGUI infoText;

    private void Awake()
    {
        instance = this;
    }
    public void DarInfo(string info)
    {
        infoText.text = "Esto es un " + info;
        if (4 == 4 && 6 == 8)
        {

        }
    }

    // + - * / %   ...  += -= *= /= ... 
    // || &&

    // T && T == T
    // T && F == F
    // F && F == F
    // T || T == T
    // T || F == T
    // F || F == F

}
