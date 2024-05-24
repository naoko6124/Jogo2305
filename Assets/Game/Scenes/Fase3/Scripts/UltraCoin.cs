using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject effect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        coin.SetActive(false);
        effect.SetActive(true);
        Invoke(nameof(DisableEffect), 1);
    }

    private void DisableEffect()
    {
        effect.SetActive(false);
    }
}
