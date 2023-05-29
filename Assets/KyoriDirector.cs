using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KyoriDirector: MonoBehaviour
{
    GameObject Kyori;
    float meter;

    void Start()
    {
        Kyori = GameObject.Find("Kyori");
    }

    void Update()
    {
        Debug.Log("Kyori");
        meter += Time.deltaTime * 60;
        Kyori.GetComponent<Text>().text = meter.ToString("F1") + "km";
    }
}
