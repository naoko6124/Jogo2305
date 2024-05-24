using System;
using System.Collections;
using System.Collections.Generic;
using Framework.UltraHUD;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class DeathHUD : MonoBehaviour
{
    public Text deathText;
    public PlayerDataScriptable playerData;

    public void Start()
    {
        deathText.text = "deaths: " + playerData.deaths;
    }
}
