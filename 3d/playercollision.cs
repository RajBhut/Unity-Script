
using UnityEngine;

public class playercollision : MonoBehaviour {


 void OnCollisionEnter(Collision collisioninfo)
 {
    if (collisioninfo.collider.name == "Obstacle");
    {
        Debug.Log("we hit obstical");
    }

 }






}
    
