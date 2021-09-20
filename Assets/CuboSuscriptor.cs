using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboSuscriptor : MonoBehaviour
{
    private void Start()
    {
        ManagerCubos.instance.onCallCubos += JumpOnCall;
    }
    public void JumpOnCall(float power)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * power);
    }
}
