
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerxdire : MonoBehaviour
{
   public float speed = 0.5f;

   public float thrust = 10f;  
  
  
   

   
 Rigidbody rb;

     
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(xDirection,0f,0f);

        transform.position += moveDirection * speed;

         //rb.AddForce(Vector3.forward*200f);

         transform.Translate  (new Vector3(0f,0,thrust)*Time.deltaTime);


       


         
 



         


        // if(Input.GetKeyDown(KeyCode.Space)){

        

        // rb.AddForce(Vector3.forward*500);
        // }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "enemy" )
        {
            Destroy(gameObject);
   
                
        }
        if(other.collider.tag == "enemysp" )
        {
            Destroy(gameObject);
   
                
        }
          if(other.collider.tag == "Finish" )
        {
          
                next();
        }
          if(other.collider.tag == "enemy" )
        {
          
                lose();
        }
       
          if(other.collider.tag == "enemysp" )
        {
          
                lose();
        }
       
        



    }
      public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }
     public void lose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

}
