//using System.Diagnostics;
//using System.Diagnostics;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "enemy")
        {
        Destroy(gameObject);
        

        }
        
    }
}
