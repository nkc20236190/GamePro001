using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // UI‚ðŽg‚¤‚Ì‚Å–Y‚ê‚¸‚É  

public class GameDirector : MonoBehaviour
{
    public float limit = 1.0f / 6000.0f;
    GameObject Time_gauge;
    float time = 1.0f;

    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    private void Update()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= limit;
    }

    public void DecreaseTime()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 1.0f / 600.0f;
    }
}
