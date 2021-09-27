using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class AirwingController : MonoBehaviour
{
    public float referencia = 0;
    public Transform airwing;
    public Transform controller;
    public float speedAirwing = 5;
    public float speedRail = 1;
    public Vector2 limit;
    public Rigidbody rb;
    public CinemachineDollyCart dl;
    
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //rb.velocity = new Vector3(x * speedAirwing, y* speedAirwing, 0).normalized;
        controller.Translate(Vector3.right * x * Time.deltaTime * speedAirwing);
        controller.Translate(Vector3.up * y * Time.deltaTime * speedAirwing);
        Vector3 limitPos = controller.transform.localPosition;
        limitPos.x = Mathf.Clamp(limitPos.x, -limit.x, limit.x);
        limitPos.y = Mathf.Clamp(limitPos.y, -limit.y, limit.y);
        controller.transform.localPosition = limitPos;

        Vector3 localRotation = airwing.localEulerAngles;
        localRotation.x = Mathf.LerpAngle(localRotation.x, y * -30, 0.2f);
        localRotation.y = Mathf.LerpAngle(localRotation.y, x * 30, 0.2f); 
        localRotation.z = Mathf.LerpAngle(localRotation.z, x * -30, 0.2f);
        airwing.localEulerAngles = localRotation;


        dl.m_Position += speedRail * Time.deltaTime;

    }
}
