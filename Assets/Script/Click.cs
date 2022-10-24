using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UniRx;
using UniRx.Triggers;
using System;


public class Click : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    Button _button;

    public void OnPointerClick(PointerEventData eventData)
    {
        print(transform.name);
        Mole.Score += 10;

        
    }
}
