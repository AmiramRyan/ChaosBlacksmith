using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    public GameManager gameManager;
    public ScoreValue currentScore;
    void Update()
    {
        scoreText.text ="" + currentScore.runTimeValueScore;
    }

    public void AddScore(int amount)
    {
        currentScore.runTimeValueScore += amount;
        gameManager.questDone++;
        gameManager.questChange = true;
    }
}
