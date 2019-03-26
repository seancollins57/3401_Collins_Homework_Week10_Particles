using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStarter : MonoBehaviour
{
    public ParticleSystem FireParticles;

    void Start()
    {
        
    }


    void Update()
    {
        //Functions like play, isPlaying,stop are all used for detecting animation
        if (Input.GetKeyDown(KeyCode.Space));
        {
            FireParticles.Play();
        }
        //Self explainatory line of code
        if (FireParticles.isPlaying)
        {
            FireParticles.Stop();
        }
        else
        {
            FireParticles.Play();
        }
    }
}


