using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        
        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // �G�̔��a
        float r2 = 0.5f;  // �v���C���̔��a

        if (d < r1 + r2)
        {
            Destroy (gameObject);
        }
    }

}
