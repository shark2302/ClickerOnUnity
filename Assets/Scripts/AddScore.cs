using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField]
    private static int scoreValue;

    Text score;
    // Start is called before the first frame update
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
}
