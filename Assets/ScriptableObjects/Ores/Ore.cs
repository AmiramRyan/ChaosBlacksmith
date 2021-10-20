using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ore : ScriptableObject
{
    public string oreName;
    public float meltingPoint;
    public float errorMargin; // how much of a tempeture diffrance still count as success
    public Sprite oreSprite;
}
