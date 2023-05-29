using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    //x軸方向の移動範囲の最小値
    [SerializeField] private float _minX = -10.5f;
    //x軸方向の移動範囲の最大値
    [SerializeField] private float _maxX = 10.5f;
    //y軸方向の移動範囲の最小値
    [SerializeField] private float _minY = -4.5f;
    //y軸方向の移動範囲の最大値
    [SerializeField] private float _maxY = 4.5f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {

        float speed = 0.1f;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x * speed, y * speed, 0);

        Vector3 pos = transform.position;

        //x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        //y軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        transform.position = pos;


    }
}
