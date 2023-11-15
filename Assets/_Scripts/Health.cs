using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject _fire_1;
    [SerializeField] private GameObject _fire_2;
    [SerializeField] private GameObject _fire_3;
    [SerializeField] private GameObject _fire_4;
    [SerializeField] private GameObject _fire_5;
    [SerializeField] private GameObject _fire_6;

    [SerializeField] private GameObject _gameOverPanel;

    
    public static int hp = 6;

    private void Start()
    {
        hp = 6;
        Debug.Log(hp);
    }

    public void CheckHP()
    {
        if (hp == 6)
        {
            Fire6();
        }
        else if (hp == 5)
        {
            Fire5();
            
        }
        else if (hp == 4)
        {
            Fire4();

        }
        else if (hp == 3)
        {
            Fire3();

        }
        else if (hp == 2)
        {
            Fire2();

        }
        else if (hp == 1)
        {
            Fire1();

        }
        else if (hp == 0)
        {
            Fire0();
            GameOverBehavior();
        }
    }

    private void GameOverBehavior()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void Fire6()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(true);
        _fire_3.SetActive(true);
        _fire_4.SetActive(true);
        _fire_5.SetActive(true);
        _fire_6.SetActive(true);
    }

    private void Fire5()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(true);
        _fire_3.SetActive(true);
        _fire_4.SetActive(true);
        _fire_5.SetActive(true);
        _fire_6.SetActive(false);
    }

    private void Fire4()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(true);
        _fire_3.SetActive(true);
        _fire_4.SetActive(true);
        _fire_5.SetActive(false);
        _fire_6.SetActive(false);
    }

    private void Fire3()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(true);
        _fire_3.SetActive(true);
        _fire_4.SetActive(false);
        _fire_5.SetActive(false);
        _fire_6.SetActive(false);
    }

    private void Fire2()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(true);
        _fire_3.SetActive(false);
        _fire_4.SetActive(false);
        _fire_5.SetActive(false);
        _fire_6.SetActive(false);
    }

    private void Fire1()
    {
        _fire_1.SetActive(true);
        _fire_2.SetActive(false);
        _fire_3.SetActive(false);
        _fire_4.SetActive(false);
        _fire_5.SetActive(false);
        _fire_6.SetActive(false);
    }

    private void Fire0()
    {
        _fire_1.SetActive(false);
        _fire_2.SetActive(false);
        _fire_3.SetActive(false);
        _fire_4.SetActive(false);
        _fire_5.SetActive(false);
        _fire_6.SetActive(false);
    }
}