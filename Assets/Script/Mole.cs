using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class Mole : MonoBehaviour
{
    public static int Score;

    List<GameObject> _moles = new();

    [SerializeField]
    [Header("�ǂ̂��炢��������")]
    float _movePos;

    [SerializeField]
    [Header("�㉺�X�s�[�h")]
    float _moveSpeed = 0.3f;




    private void Start()
    {

        StartCoroutine(CoolTime());
    }
    
    IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(1f);
        this.transform.DOMoveY(_movePos, _moveSpeed)
            .SetLoops(2, LoopType.Yoyo)
            .OnComplete(() => StartCoroutine(CoolTime()));
    }
}