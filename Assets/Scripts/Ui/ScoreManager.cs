using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public ScoreValue currentScore;
    // Update is called once per frame
    void Update()
    {
        scoreText.text ="" + currentScore.runTimeValueScore;
    }

    public void AddScore(int amount)
    {
        currentScore.runTimeValueScore += amount;
    }
}
