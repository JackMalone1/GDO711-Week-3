using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Phone : MonoBehaviour, IPointerClickHandler
{
    private Image _image;
    [FormerlySerializedAs("_other")] [SerializeField] private GameObject other;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        other.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
