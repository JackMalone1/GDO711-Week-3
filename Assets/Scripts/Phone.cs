using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Phone : MonoBehaviour, IPointerClickHandler
{
    private Image _image;
    [SerializeField] private GameObject _other;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        _other.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
