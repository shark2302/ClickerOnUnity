using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{

    [SerializeField] private Controller _controller;
    [SerializeField] private float _mainTimer = 60;
    [SerializeField] private Text _uiText;
    [SerializeField] private GameObject _spawner;
    private float _timer;
    private bool _started = false;

    void Update()
    {
        if(!_started)
            return;
        if (_timer > 0.0f)
        {
            _timer -= Time.deltaTime;
            _uiText.text = _timer.ToString("F");
        }
        else if (_timer <= 0)
        {
            _timer = 0.0f;
            _uiText.text = _timer.ToString("F");
           
            _started = false;
            //Invoke("LoadEndGameView", 0.5f);
            StartCoroutine(EndGameCoroutine());
        }
    }

    IEnumerator EndGameCoroutine()
    {
        _spawner?.SetActive(false);
       /* var clones = _spawner.GetAsteroidList();
        foreach (var clone in clones)
        {
            if (clone != null) ;
            Destroy(clone);
        }
        */
        yield return new WaitForSeconds(0.5f);
        LoadEndGameView();
       
    }
    private void OnEnable()
    {
        _timer = _mainTimer;
        _started = true;
        _spawner?.SetActive(true);
    }

    private void LoadEndGameView()
    {
        _controller?.LoadEndGameView();
    }

    
}
