using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidKiller : MonoBehaviour
{
    
    private void OnMouseDown()
    { 
            AddScore.InctementScore();
            Destroy(gameObject);
        }
}