using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement3D : MonoBehaviour
{
    private Rigidbody rb;
    public float speedCharacter = 10;
    public Transform worldReference;
    public float maxSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.AddForce(worldReference.forward * speedCharacter * z * Time.deltaTime);
        rb.AddForce(worldReference.right * speedCharacter * x * Time.deltaTime);

        if( x==0 && z ==0)
        {
            rb.velocity = rb.velocity * .9f;
        }

        Vector3 vel = rb.velocity;
        vel.x = Mathf.Clamp(vel.x, -maxSpeed, maxSpeed);
        vel.y = Mathf.Clamp(vel.y, -maxSpeed, maxSpeed);
        vel.z = Mathf.Clamp(vel.z, -maxSpeed, maxSpeed);
        rb.velocity = vel;

    }
}
