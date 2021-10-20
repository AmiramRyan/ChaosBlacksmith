using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Ore : ScriptableObject
{
    [SerializeField] private string oreName;
    [SerializeField] private float meltingPoint;
    [SerializeField] private float errorMargin; // how much of a tempeture diffrance still count as success
    public Sprite oreSprite;
}
