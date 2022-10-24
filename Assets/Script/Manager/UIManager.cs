using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    [Header("�X�R�A�e�L�X�g")]
    Text _scoreText;

    void Update()
    {
        _scoreText.text = Mole.Score.ToString("D5");
    }
}
