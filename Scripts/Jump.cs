using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody rb;
    public float MoveSpeed;
    float Xinput;
    float Yinput;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Xinput = Input.GetAxis("Horizontal");
        Yinput = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(Xinput * MoveSpeed, 0, Yinput * MoveSpeed);
    }

}
