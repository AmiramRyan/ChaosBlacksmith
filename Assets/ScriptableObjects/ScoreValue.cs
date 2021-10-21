using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScoreValue : ScriptableObject
{
    public float initialValueScore;
    public float runTimeValueScore;
    public float highScore;

    private void OnEnable()
    {
        runTimeValueScore = initialValueScore;
    }

    public void RecordHighScore()
    {
        if (runTimeValueScore > highScore)
        {
            highScore = runTimeValueScore;
        }
    }

}
