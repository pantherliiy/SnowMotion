﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AvalancheStartCheck : MonoBehaviour
{

    public ParticleSystem ps;

  
    public List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();

    public static bool avalancheStart;

    void Start()
    {
    }

    void Update()
    {
    }



    void onEnable()
    {
        ps = GetComponent <ParticleSystem>();
    }

    void OnParticleTrigger()
    {

        int enterParticleNumber = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);

        for (int i = 0; i < enterParticleNumber; i++)
        {

            ParticleSystem.Particle p = enter[i];
            avalancheStart = true;
      

        } 
       
    }

}