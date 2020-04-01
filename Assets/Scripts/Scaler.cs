using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scaler : MonoBehaviour
{
    private Animator _animator;
    [SerializeField]
   

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
        
        if (gameObject.transform.localScale.x > 1.8)
        {
            AddScore.DecrementScore();
            Destroy(gameObject);
            
        }
        gameObject.transform.localScale *= 1.001f;
    }
    
}
