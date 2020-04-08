using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scaler : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    
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
