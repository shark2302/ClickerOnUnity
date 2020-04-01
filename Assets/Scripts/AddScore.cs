using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    
    private static int scoreValue;
    [SerializeField]
    private Text score;
    
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
    }

    public static int GetScore()
    {
        return scoreValue;
    }

    public static void InctementScore()
    {
        scoreValue++;
    }

    public static void ResetScore()
    {
        scoreValue = 0;
    }

    public static void DecrementScore()
    {
        scoreValue -= 5;
    }
}
