using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
  

    

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
            rb.AddForce(Vector3.up * 150);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.forward * 50);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.forward * -50);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddForce(Vector3.right * 50);
        } 

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.left * 50);
            
        }
            void OnCollisionEnter(Collision Collision)
        {
            if (Collision.gameObject.tag == "Player")
            Destroy(gameObject);
        }
                
      
        
        
    }
}
