using UnityEngine;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
}
