using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public ScoreValue score;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "High Score: " + score.highScore;
    }

}
