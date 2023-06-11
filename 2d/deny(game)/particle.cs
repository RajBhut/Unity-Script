using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    ParticleSystem dust;
    void Start()
    {
        dust =GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
          dust.Play();
      }
       dust.Stop();
    }
}
