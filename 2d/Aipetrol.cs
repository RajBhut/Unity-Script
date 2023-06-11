
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aipetrol : MonoBehaviour
{

    public Transform groundcheckPos;
    private bool mustTurn;
    public float walkspeed;
// [HideInspector]
     public bool mustpatrol;
     public Collider2D bodycollider;

     public LayerMask groundLayer;
     public Rigidbody2D rb;
       void Start()
    {
        mustpatrol = true;
    }

       
    void Update()
    {
        if (mustpatrol)
        {
             Patrol();
        }
    }
       private  void FixedUpdate()
       {
           if(mustpatrol)
           {
               mustTurn = !Physics2D.OverlapCircle(groundcheckPos.position,0.1f, groundLayer);
           }
       }
     void Patrol()
     {

         if(mustTurn || bodycollider.IsTouchingLayers(groundLayer))
         {
             Flip();
         }
      rb.velocity = new Vector2(walkspeed*Time.fixedDeltaTime,rb.velocity.y);

     }

     void Flip()
     {
         mustpatrol = false;
         transform.localScale = new Vector2(transform.localScale.x*-1,transform.localScale.y);
         walkspeed *= -1;
         mustpatrol = true;


     }
  


}

