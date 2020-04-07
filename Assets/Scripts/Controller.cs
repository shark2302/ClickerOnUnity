using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{

    [SerializeField] private Canvas _hud; 
    [SerializeField] private Canvas _endGame;
    [SerializeField] private GameObject _game;
    

    public void LoadGame()
    {
        if (PlayerPrefs.GetInt("HighScore") < AddScore.GetScore())
        {
            PlayerPrefs.SetInt("HighScore", AddScore.GetScore());
        }
        AddScore.ResetScore();
        _hud?.gameObject.SetActive(true);
        gameObject.SetActive(false);
        _game?.SetActive(true);
        _endGame?.gameObject.SetActive(false);
    }

    public void LoadEndGameView()
    {
        _hud?.gameObject.SetActive(false);
        _game?.SetActive(false);
        _endGame?.gameObject.SetActive(true);
    }
    
    
}
