using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtn : MonoBehaviour
{
    public ScoreValue score;
    public void Restart()
    {
        score.runTimeValueScore = score.initialValueScore;
        SceneManager.LoadScene("MainGame");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
