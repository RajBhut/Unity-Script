
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Vector3 camaraoffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + camaraoffset;
    }
}
