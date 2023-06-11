
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float MovmentSpeed;
    public float jumpForce;
    public bullate ProjectilePrefab;
   
     public Transform Launchoffset;

     private Rigidbody2D  _rigidbody;
    ParticleSystem dust;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        dust = GetComponent<ParticleSystem>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        var movment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movment,0,0)*Time.deltaTime * MovmentSpeed;

        if(!Mathf.Approximately(0,movment))
        transform.rotation = movment < 0 ? Quaternion.Euler(0,180,0):Quaternion.identity;
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2 (0,jumpForce),ForceMode2D.Impulse);
            dust.Play();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, Launchoffset.position, transform.rotation);
        }
          
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="enemy")
        {
            Destroy(gameObject);
        }
       
    }
}
