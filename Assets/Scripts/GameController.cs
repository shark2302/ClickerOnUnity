using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] private Controller _controller;
    [SerializeField] private float _mainTimer = 60;
    [SerializeField] private Text _uiText;
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
            _controller.LoadEndGameView(); 
            var clones = GameObject.FindGameObjectsWithTag ("Clone");
            foreach (var clone in clones)
            {
                Destroy(clone);
                Debug.Log("Destr");
            }
            

            _started = false;
        }
        
    }

    private void OnEnable()
    {
        _timer = _mainTimer;
        _started = true;
    }
}
