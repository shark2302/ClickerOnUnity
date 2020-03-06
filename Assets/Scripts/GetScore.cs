using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    Text _resScore;

    private void Start()
    {
        _resScore = GetComponent<Text>();
        _resScore.text = "Ваш результат - " + AddScore.scoreValue;
    }


}
