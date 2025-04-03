using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int teamAScore = 0;
    public int teamBScore = 0;
    public TextMeshProUGUI teamAScoreText;
    public TextMeshProUGUI teamBScoreText;

    void Start()
    {
        // Initialize the score display
        UpdateScoreDisplay();
    }

    public void UpdateScore(int team, int points)
    {
        if (team == 0)
        {
            teamAScore += points;
        }
        else
        {
            teamBScore += points;
        }
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        teamAScoreText.text = "Team A: " + teamAScore.ToString();
        teamBScoreText.text = "Team B: " + teamBScore.ToString();
    }

    // New function to handle goal scoring
    public void GoalScored(int team)
    {
        UpdateScore(team, 1);
    }
}
