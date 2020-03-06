using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneLoader : MonoBehaviour
{
   
    public void LoadGame()
    {
        AddScore.scoreValue = 0;
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    
    
}
