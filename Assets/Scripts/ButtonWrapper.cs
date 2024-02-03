using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWrapper : MonoBehaviour
{
    [SerializeField] private DrinkCreation drinkCreation;

    public void ResetDrink()
    {
        drinkCreation.ResetDrink();
    }

    public void BrewDrink()
    {
        drinkCreation.Brew();
    }
}
