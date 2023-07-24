using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhyscisController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void Update()
    {
        


        float dir = Input.GetAxis("Horizontal");
        transform.Rotate(dir * Vector3.up*turnSpeed*Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * speed * Time.deltaTime;
    }
}
