using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject effect;

    private bool canTrigger = true;
    
    private float durationOfCollectedParticleSystem;

    private void Start()
    {
        durationOfCollectedParticleSystem = effect.GetComponent<ParticleSystem>().main.duration;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (canTrigger)
        {
            coin.SetActive(false);
            effect.SetActive(true);
            Invoke(nameof(DisableEffect), durationOfCollectedParticleSystem);
            canTrigger = false;
        }
    }

    private void DisableEffect()
    {
        effect.SetActive(false);
    }
}
