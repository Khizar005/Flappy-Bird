using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager instance;

    [SerializeField] GameObject GameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private int scoreToAdd;

    private void Awake()
    {
        instance = this;
    }
    public void Dead()
    {
        GameOverPanel.SetActive(true);
        UI.instance.OnPauseButtonClicked();

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverPanel.SetActive(false);
    }
    public void AddScore()
    {
        scoreToAdd++;
        scoreText.text = "Score: " + scoreToAdd;
        PlayerPrefs.SetInt("Score", scoreToAdd);
    }

}
