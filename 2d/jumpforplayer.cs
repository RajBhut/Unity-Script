
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpforplayer : MonoBehaviour
{
//  Rigidbody2D rb;
// private bool jump = false;
//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2d>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//          if (Input.GetKeyDown(KeyCode.Space))
//         {
//            jump=true;
 
//     }
   
//       void OnCollisionStay2D(Collision2D other) 
//     {
//       if (other.gameObject.tag == "Base" && jump=true) 
//       {
//           rb.AddForce(Vector3.up * 5f);
//           jump=false;
//         }
    
//       }
      
      

//     }

// }

  public Vector3 jump;
          public float jumpForce = 2.0f;
      
          public bool isGrounded;
          Rigidbody2D rb;
          void Start(){
              rb = GetComponent<Rigidbody2D>();
              jump = new Vector3(0.0f, 2.0f, 0.0f);
          }
      
          void OnCollisionStay2D()
          {
              isGrounded = true;
          }
          void OnCollisionExit2D(){
            isGrounded = false;
      }
          void Update(){
              if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
      
                  rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                  isGrounded = false;

                  
              }
          }
      }