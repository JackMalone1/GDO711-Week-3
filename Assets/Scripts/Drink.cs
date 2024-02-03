using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Drink", menuName = "Drinks/Drink")]
public class Drink : ScriptableObject
{
    public DrinkComponent baseComponent;
    public DrinkComponent secondaryComponent;
    public DrinkComponent tertiaryComponent;
}
