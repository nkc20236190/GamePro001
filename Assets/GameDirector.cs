using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // UI‚ðŽg‚¤‚Ì‚Å–Y‚ê‚¸‚É  

public class GameDirector : MonoBehaviour
{
    GameObject Timegauge;

    void Start()
    {
        this.Timegauge = GameObject.Find("Timegauge");
    }

    public void DecreaseHp()
    {
        this.Timegauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
