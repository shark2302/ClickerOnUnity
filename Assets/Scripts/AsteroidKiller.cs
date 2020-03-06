using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidKiller : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddScore.scoreValue += 1;
            Destroy(gameObject);
        }
    }
}