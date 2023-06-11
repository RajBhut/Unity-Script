using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
       
    public float speed = 0.5f;
    public GameObject ball;
    public Transform spawnPoint;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
         float xDirection = Input.GetAxis("Horizontal");
         float zDirection = Input.GetAxis("Vertical");

         Vector3 moveDirection = new Vector3(xDirection,0.0f,zDirection);

         transform.position += moveDirection * speed;


        if (Input.GetKeyDown(KeyCode.Space))
        {
           SpawnBall();

        }
    }
    

    void SpawnBall()
    {
        Instantiate(ball, spawnPoint.position,Quaternion.identity);
        
    }

     
}
