using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int goals = 0;
    public int assists = 0;
    public int fouls = 0;

    public TextMeshProUGUI goalText;
    public TextMeshProUGUI assistsText;
    public TextMeshProUGUI foulsText;

    void Start()
    {
        UpdateStatsDisplay();
    }

    public void UpdateStats(int newGoals, int newAssists, int newFouls)
    {
        goals = newGoals;
        assists = newAssists;
        fouls = newFouls;
        UpdateStatsDisplay();
    }

    void UpdateStatsDisplay()
    {
        goalText.text = "Goals: " + goals.ToString();
        assistsText.text = "Assists: " + assists.ToString();
        foulsText.text = "Fouls: " + fouls.ToString();
    }
}
