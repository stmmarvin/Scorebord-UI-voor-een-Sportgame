using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 600;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI warningText;
    private bool isPaused = false;
    private bool isWarningDisplayed = false;

    void Start()
    {
        UpdateTimerDisplay();
    }

    // Als de game niet gepauzeerd is en de gameTime groter is dan 0, dan wordt de gameTime afgetrokken met Time.deltaTime
    void Update()
    {
        if (!isPaused && gameTime > 0)
        {
            gameTime -= Time.deltaTime;
            if (gameTime <= 0)
            {
                gameTime = 0;
            }
            UpdateTimerDisplay();
        }
    }
    // Hier wordt de gameTime omgezet naar minuten en seconden en wordt de timerText geupdate
    void UpdateTimerDisplay()
    {
        int minutes = (int)gameTime / 60;
        int seconds = (int)gameTime % 60;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (gameTime <= 60 && !isWarningDisplayed)
        {
            warningText.text = "Hurry up! Time is running out!";
            isWarningDisplayed = true;
        }
        else if (gameTime > 60 && isWarningDisplayed)
        {
            warningText.text = "";
            isWarningDisplayed = false;
        }
    }
    // Hier wordt de gameTime gereset naar 600 seconden
    public void TogglePause()
    {
        isPaused = !isPaused;
    }
}
