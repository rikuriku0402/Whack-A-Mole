using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public static int Score;

    [SerializeField]
    [Header("���̃|�W�V����")]
    float _nowPos;

    [SerializeField]
    [Header("�㉺�X�s�[�h")]
    float _moveSpeed = 0.3f;

    void Start()
    {
        _nowPos = this.transform.position.y;    
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, _nowPos + Mathf.PingPong(Time.time, _moveSpeed), transform.position.z);    
    }
}
