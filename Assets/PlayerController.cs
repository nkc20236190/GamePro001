using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Animator PlayerAnime;
    GameObject gameDirector;

    //x�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minX = -10.5f;
    //x�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxX = 10.5f;
    //y�������̈ړ��͈͂̍ŏ��l
    [SerializeField] private float _minY = -4.5f;
    //y�������̈ړ��͈͂̍ő�l
    [SerializeField] private float _maxY = 4.5f;
    void Start()
    {
        gameDirector = GameObject.Find("GameDirector");
        PlayerAnime = GetComponent<Animator>();
    }

    private void Update()
    {
        float speed = 0.1f;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x * speed, y * speed, 0);
        PlayerAnime.SetFloat("tamamitune", y);

        Vector3 pos = transform.position;

        //x�������̈ړ��͈͐���
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        //y�������̈ړ��͈͐���
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;


        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Debug.Log("a");
        if (collider.gameObject.tag == "Enemy tag")
        {
            gameDirector.GetComponent<GameDirector>().DecreaseTime();
            Destroy(collider.gameObject);

        }
    }
}
