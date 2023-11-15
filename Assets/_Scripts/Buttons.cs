using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private Text _menuBestText;


    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("bestScore", 0);
        _menuBestText.text = "Best: " + bestScore.ToString();
        Time.timeScale = 0;
        int start = PlayerPrefs.GetInt("start", 0);
        if (start == 1)
        {
            _menuPanel.SetActive(false);
            PlayerPrefs.SetInt("start", 0);
            Time.timeScale = 1;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("start", 1);
    }

    public void StartGame()
    {
        _menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("start", 0);
    }
}
