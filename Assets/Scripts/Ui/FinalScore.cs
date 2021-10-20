using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public ScoreValue score;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Final Score: " + score.runTimeValueScore;
    }

}
