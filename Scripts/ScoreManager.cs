using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreCount;
    public static int highScoreCount;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetInt("HighScore");
        }
    }

    void Update()
    {
        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", highScoreCount);
        }

        scoreText.text = "Score: " + scoreCount;
    }
}
