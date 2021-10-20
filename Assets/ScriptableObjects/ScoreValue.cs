using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreValue : ScriptableObject
{
    public float initialValueScore;
    public float runTimeValueScore;

    private void OnEnable()
    {
        runTimeValueScore = initialValueScore;
    }
}
