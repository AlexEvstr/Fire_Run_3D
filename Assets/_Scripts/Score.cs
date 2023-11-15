using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _gameOverScoreText;
    [SerializeField] private Text _gameOverBestText;
    
    private int _score;
    private int _bestScore;

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("bestScore", 0);
        StartCoroutine(IncreaseScore());
    }

    private void Update()
    {
        if (_bestScore < _score)
        {
            _bestScore = _score;
            PlayerPrefs.SetInt("bestScore", _bestScore);
        }
        _scoreText.text = "Score  " + _score.ToString();
        _gameOverScoreText.text = "Score  " + _score.ToString();
        _gameOverBestText.text = "Best: " + _bestScore.ToString();
    }

    private IEnumerator IncreaseScore()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            _score++;
        }
    }
}
