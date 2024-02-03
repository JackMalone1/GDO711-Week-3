using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DrinkComponent", menuName = "Drinks/DrinkComponent")]
public class DrinkComponent : ScriptableObject
{
    public int warmness;
    public int coolness;
    public int sweetness;
    public int bitterness;
}
