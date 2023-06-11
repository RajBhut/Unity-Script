using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolenemy : MonoBehaviour
{
  
public float speed;
public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
     
       

       
        Vector3 moveDirection = new Vector3(1f,0f,0f);

        transform.position += moveDirection * speed;
    }
     private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="enemy")
        {
               flip();  
         }
    }
    void flip()
    {
        speed *= -1;
    }
}
