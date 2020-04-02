using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    [SerializeField]
    private Text _resScore;

    private void OnEnable()
    {
        _resScore = GetComponent<Text>();
        _resScore.text = "Ваш результат : " + AddScore.GetScore() + "\n" + "Лучший результат : " + PlayerPrefs.GetInt("HighScore");
        
    }


}
