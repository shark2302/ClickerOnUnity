using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scaler : MonoBehaviour
{
    private Animation _animation;

    private void Start()
    {
        _animation = GetComponent<Animation>();
    }


    void Update()
    {
        if (gameObject.transform.localScale.x > 1.3)
        {
            _animation.Play();
        }
        
        if (gameObject.transform.localScale.x > 1.5)
        {
            SceneManager.LoadScene("RestartScene", LoadSceneMode.Single);
            Destroy(gameObject);
            
        }
        gameObject.transform.localScale *= 1.001f;
    }
    
}
