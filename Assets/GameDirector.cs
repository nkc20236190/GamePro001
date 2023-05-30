using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;    // UI‚ðŽg‚¤‚Ì‚Å–Y‚ê‚¸‚É  
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    int hit =0;

    GameObject Time_gauge;
    GameObject Kyori;
    

    [SerializeField] float limit;
    [SerializeField] float time; 
    float meter;
    

    void Start()
    {
        Kyori = GameObject.Find("Kyori");
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    private void Update()
    {
        meter += Time.deltaTime;
        Kyori.GetComponent<Text>().text = meter.ToString("F2") + "km";

        time -= 1.0f / limit * Time.deltaTime;
        this.Time_gauge.GetComponent<Image>().fillAmount -= 1.0f / limit * Time.deltaTime;

        if (this.Time_gauge.GetComponent<Image>().fillAmount <= 0)
        {
            Debug.Log("b");
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void DecreaseTime()
    {
        //this.Time_gauge.GetComponent<Image>().fillAmount -= 1.0f / 600.0f; 
        Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
        time -= 1.0f / limit;
    }

}
