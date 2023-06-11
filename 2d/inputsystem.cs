using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class inputsystem : MonoBehaviour
{
   
private Rigidbody spheareRigidbody;

 private void Awake()
{
    spheareRigidbody = GetComponent<Rigidbody>();
}
   public void Jump(InputAction.CallbackContext context){
       Debug.Log("Jump"+ context.phase);
       spheareRigidbody.AddForce(Vector3.up * 3f, ForceMode.Impulse);
   }
}
