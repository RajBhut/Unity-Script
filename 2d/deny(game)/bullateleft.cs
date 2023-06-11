

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullateleft : MonoBehaviour
{
    
    public float speed = -50f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform .right * Time.deltaTime * speed;

          Destroy(gameObject,5f);

        //  rb.AddForce(Vector3.forward * 50*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collioson)
    {
        // Destroy(gameObject);
        if(collioson.collider.tag=="enemy")
        {
            Destroy(gameObject);
        }
    }
}
