using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject VoetbalveldButton;
    public GameObject VoetbalButton;
    public Timer timer;

    void Start()
    {
        VoetbalveldButton.SetActive(true);
        VoetbalButton.SetActive(false);
    }

    public void Pause()
    {
        VoetbalveldButton.SetActive(false);
        VoetbalButton.SetActive(true);
        timer.TogglePause();
    }

    public void Resume()
    {
        VoetbalveldButton.SetActive(true);
        VoetbalButton.SetActive(false);
        timer.TogglePause();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
