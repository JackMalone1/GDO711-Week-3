using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DrinkCreation : MonoBehaviour
{
    [SerializeField] private Drink desiredDrink;

    private DrinkComponent _baseComponent = null;
    private DrinkComponent _secondaryComponent = null;
    private DrinkComponent _tertiaryComponent = null;
    
    private TextMeshProUGUI baseComponentText;
    private TextMeshProUGUI secondaryComponentText;
    private TextMeshProUGUI tertiaryComponentText;
   
    private TextMeshProUGUI warmnessComponentText;
    private TextMeshProUGUI coolnessComponentText;
    private TextMeshProUGUI sweetnessComponentText;
    private TextMeshProUGUI bitternessComponentText;
    
    [SerializeField] private GameObject baseComponentTextObj;
    [SerializeField] private GameObject secondaryComponentTextObj;
    [SerializeField] private GameObject tertiaryComponentTextObj;
    
    [SerializeField] private GameObject warmnessComponentTextObj;
    [SerializeField] private GameObject coolnessComponentTextObj;
    [SerializeField] private GameObject sweetnessComponentTextObj;
    [SerializeField] private GameObject bitternessComponentTextObj;

    private void Awake()
    {
        baseComponentText = baseComponentTextObj.GetComponent<TextMeshProUGUI>();
        secondaryComponentText = secondaryComponentTextObj.GetComponent<TextMeshProUGUI>();
        tertiaryComponentText = tertiaryComponentTextObj.GetComponent<TextMeshProUGUI>();
        warmnessComponentText = warmnessComponentTextObj.GetComponent<TextMeshProUGUI>();
        coolnessComponentText = coolnessComponentTextObj.GetComponent<TextMeshProUGUI>();
        sweetnessComponentText = sweetnessComponentTextObj.GetComponent<TextMeshProUGUI>();
        bitternessComponentText = bitternessComponentTextObj.GetComponent<TextMeshProUGUI>();
    }

    public void ResetDrink()
    {
        _baseComponent = null;
        _secondaryComponent = null;
        _tertiaryComponent = null;
        
        Debug.Log("Reset");
    }

    public void Brew()
    {
        if (_baseComponent != null && _secondaryComponent != null && _tertiaryComponent != null)
        {
            if (desiredDrink.baseComponent == _baseComponent && desiredDrink.secondaryComponent == _secondaryComponent
                                                             && desiredDrink.tertiaryComponent == _tertiaryComponent)
            {
                Debug.Log("brewing");
            }
            else
            {
                Debug.Log("Must pick all components");
            }
        }
    }

    public void AddComponentToDrink(DrinkComponent component)
    {
        if (_baseComponent == null)
        {
            _baseComponent = component;
            baseComponentText.text = component.name;
        }
        else if (_secondaryComponent == null)
        {
            _secondaryComponent = component;
            secondaryComponentText.text = component.name;
        }
        else if(_tertiaryComponent == null)
        {
            _tertiaryComponent = component;
            tertiaryComponentText.text = component.name;
        }
        UpdateDrinkValues();
        Debug.Log("Added component");
    }

    void UpdateDrinkValues()
    {
        int bitterness = 0, sweetness = 0, warmness = 0, coolness = 0;

        if (_baseComponent != null)
        {
            bitterness += _baseComponent.bitterness;
            sweetness += _baseComponent.sweetness;
            warmness += _baseComponent.warmness;
            coolness += _baseComponent.coolness;
        }
        
        //components don't add as much when not used as primary components
        
        if (_secondaryComponent != null)
        {
            bitterness += _secondaryComponent.bitterness - 1;
            sweetness += _secondaryComponent.sweetness - 1;
            warmness += _secondaryComponent.warmness - 1;
            coolness += _secondaryComponent.coolness - 1;
        }
        
        if (_tertiaryComponent != null)
        {
            bitterness += _tertiaryComponent.bitterness - 2;
            sweetness += _tertiaryComponent.sweetness - 2;
            warmness += _tertiaryComponent.warmness - 2;
            coolness += _tertiaryComponent.coolness - 2;
        }

        bitternessComponentText.text = $"Bitterness: {bitterness}";
        sweetnessComponentText.text = $"Sweetness: {sweetness}";
        coolnessComponentText.text = $"Coolness: {coolness}";
        warmnessComponentText.text = $"Warmness: {warmness}";
    }
}
