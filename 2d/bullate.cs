

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullate : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += transform .forward * Time.deltaTime * speed;

          Destroy(gameObject,5f);

         rb.AddForce(Vector3.forward * 50*Time.deltaTime);
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
