using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
  

    

{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 300);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 200);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddForce(Vector3.forward * -200);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.right * 200);
        } 

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 200);
            
        }
           
                
      
        
        
    }
}
