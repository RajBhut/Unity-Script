using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsshoot : MonoBehaviour
{
    public GameObject fire;
    public Transform spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(fire, spawnpoint.position, transform.rotation);
        }
    }
}
