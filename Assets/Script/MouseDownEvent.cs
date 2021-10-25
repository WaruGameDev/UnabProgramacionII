using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
    public UnityEvent onClickObject;
    public string nombreObjeto;

    private void OnMouseDown()
    {
        onClickObject?.Invoke();
        ManagerInfo.instance.DarInfo(nombreObjeto);
    }

}
