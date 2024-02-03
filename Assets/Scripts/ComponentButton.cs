using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentButton : MonoBehaviour
{
    [SerializeField] private DrinkComponent component;
    [SerializeField] private DrinkCreation finalDrink;

    public void AssignDrinkComponentToFinalDrink()
    {
        Debug.Log($"Adding {component.name} to drink");
        finalDrink.AddComponentToDrink(component);
    }
}
