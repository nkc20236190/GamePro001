using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // UI‚ðŽg‚¤‚Ì‚Å–Y‚ê‚¸‚É  

public class GameDirector : MonoBehaviour
{
    GameObject Kyori;
    float meter;

    public float limit = 1.0f / 6000.0f;
    GameObject Time_gauge;
    float time = 1.0f;

    void Start()
    {
        Kyori = GameObject.Find("Kyori");
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    private void Update()
    {
        meter += Time.deltaTime;
        Kyori.GetComponent<Text>().text = meter.ToString("F2") + "km";
        this.Time_gauge.GetComponent<Image>().fillAmount -= limit;
    }

    public void DecreaseTime()
    {
        time -= Time.deltaTime;
        this.Time_gauge.GetComponent<Image>().fillAmount -= 1.0f / 600.0f; 
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
