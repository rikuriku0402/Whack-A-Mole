using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    [Header("�J�E���g�_�E��")]
    float _countDown;

    [SerializeField]
    [Header("�J�E���g�_�E���e�L�X�g")]
    Text _timeText;

    void Update()
    {
        _countDown -= Time.deltaTime;

        _timeText.text = _countDown.ToString("f1") + "�b";

        if (_countDown <= 0)
        {
            _timeText.text = "���ԂɂȂ�܂���";
        }
    }
}
