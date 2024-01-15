using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    int highScoreCount;

    private void Awake()
    {
        highScoreCount = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "High Score: " + highScoreCount;
    }
}
