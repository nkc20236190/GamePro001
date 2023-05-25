using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrenab;
    float span = 0.5f;
    float delta = 0;
    
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrenab);
            int px = Random.Range(5, -5);
            go.transform.position = new Vector2(10, px);
        }
    }
}
