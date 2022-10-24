using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    [Header("スコアテキスト")]
    Text _scoreText;

    void Update()
    {
        _scoreText.text = Mole.Score.ToString("D5");
    }
}
