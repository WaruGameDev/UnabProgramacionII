using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
    public UnityEvent onClickObject;

    private void OnMouseDown()
    {
        onClickObject?.Invoke();
    }

}
