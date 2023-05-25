using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
       // ¶–îˆó
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.05f, 0);
        }
        // ‰E–îˆó
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.05f, 0);
        }
        // ã–îˆó
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        // ‰º–îˆó
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }
    }
}
