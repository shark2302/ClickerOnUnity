using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scaler : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (gameObject.transform.localScale.x > 1.3)
        {
            _animator.SetTrigger("DangerTrigger");
        }
        
        if (gameObject.transform.localScale.x > 1.5)
        {
            SceneManager.LoadScene("RestartScene", LoadSceneMode.Single);
            Destroy(gameObject);
            
        }
        gameObject.transform.localScale *= 1.001f;
    }
    
}
