using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    [Header("カウントダウン")]
    float _countDown;

    [SerializeField]
    [Header("カウントダウンテキスト")]
    Text _timeText;

    void Update()
    {
        _countDown -= Time.deltaTime;

        _timeText.text = _countDown.ToString("f1") + "秒";

        if (_countDown <= 0)
        {
            _timeText.text = "時間になりました";
        }
    }
}
