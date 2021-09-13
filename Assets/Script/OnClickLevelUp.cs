using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickLevelUp : MonoBehaviour
{
    public UnityEvent onClick;    

    private void OnMouseDown()
    {
        //onClick?.Invoke();
        OnClick();
        ManagerClicker.instance.cantidadDeClicks++;
    }

    public void OnClick()
    {
        ManagerClicker.instance.OnLevelUP();
    }
    

}
