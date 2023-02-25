using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public bird birdScript;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)  
    {
        if (birdScript.birdIsAlive)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

}
