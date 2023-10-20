using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SlowMotion : MonoBehaviour
{
    
    public bool bought;
    Kretanje script;

    void Update()
    {
        if (bought == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 0.5f;
                Time.fixedDeltaTime = Time.fixedDeltaTime * 0.5f;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Time.timeScale = 1f;
                Time.fixedDeltaTime = Time.fixedDeltaTime;
            }
        } 

    }
    public void BuySlowMotion()
    {
        script = GetComponent<Kretanje>();
        script.coins = PlayerPrefs.GetInt("Coins");
        if (script.coins < 5)
        {
            Debug.Log("No coins");
        }
        else
        {
            bought = true;
            script.coins -= 5;
            PlayerPrefs.SetInt("Coins", script.coins);
        }


    }


}
