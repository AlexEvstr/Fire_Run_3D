using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _score;

    private void Start()
    {
        StartCoroutine(IncreaseScore());
    }

    private void Update()
    {
        _scoreText.text = "Score  " + _score.ToString();
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
