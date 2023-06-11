using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcollect : MonoBehaviour
{
      public Animator animator;

     bool collect = false;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnCollisionEnter2D(Collision2D other) 
    {
     
        if (other.gameObject.tag == "Player")

        animator.SetBool("collect",true);

        if (other.gameObject.tag == "Player")
      Destroy(gameObject,1f );
      
        
       
    }
}
