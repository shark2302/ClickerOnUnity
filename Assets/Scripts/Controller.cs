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
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Canvas _endGame;
    [SerializeField] private GameObject _game;
    

    public void LoadGame()
    {
        AddScore.ResetScore();
        _hud.gameObject.SetActive(true);
        gameObject.SetActive(false);
        _game.SetActive(true);
        _spawner.gameObject.SetActive(true);
        _endGame.gameObject.SetActive(false);
        
        //SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void LoadEndGameView()
    {
        _hud.gameObject.SetActive(false);
        _game.SetActive(false);
        _spawner.gameObject.SetActive(false);
        _endGame.gameObject.SetActive(true);
    }
    
    
}
