using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [Header("UI References")]
    public TextMeshProUGUI highScoreText;
    public string highScoreFormat = "Best Score: {0}";
    
    void Start()
    {
        Debug.Log("MenuUIHandler started");
        UpdateHighScoreDisplay();
    }
    
    void UpdateHighScoreDisplay()
    {
        if (highScoreText != null)
        {
            int highScore = PlayerPrefs.GetInt("HighScore", 0);
            highScoreText.text = string.Format(highScoreFormat, highScore.ToString("N0"));
        }
    }

    public void PlayGame1()
    {
        Debug.Log("Game 1 button clicked!");
        try
        {
            SceneManager.LoadScene("Game 1");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to load Game1Scene: " + e.Message);
        }
    }

    public void PlayGame2()
    {
        Debug.Log("Game 2 button clicked!");
        try
        {
            SceneManager.LoadScene("Game 2");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to load Game2Scene: " + e.Message);
        }
    }

    public void PlayGame3()
    {
        Debug.Log("Game 3 button clicked!");
        try
        {
            SceneManager.LoadScene("Game 3");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to load Game3Scene: " + e.Message);
        }
    }

    public void Exit()
    {
        Debug.Log("Exit button clicked!");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
    
    // Update high score display when returning to menu
    void OnEnable()
    {
        UpdateHighScoreDisplay();
    }
}