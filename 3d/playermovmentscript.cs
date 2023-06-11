using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovmentscript : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 12f;

    public float gravity = -9.8f;

    Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
