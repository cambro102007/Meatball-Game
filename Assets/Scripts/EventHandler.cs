using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour

{
    public Text ScoreText;
    public int PlayerScore = 0;
    public void restartGame()
    {
        SceneManager.UnloadSceneAsync("Game");
        SceneManager.LoadScene("Game");
    }
    public void AddScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }
}
