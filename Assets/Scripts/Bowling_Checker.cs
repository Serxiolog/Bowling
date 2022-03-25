using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bowling_Checker : MonoBehaviour
{
    public Text ScoreController;
    public List<Tall> talls;
    public int Score;

    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        int score = 0;
        foreach(var tall in talls)
        {
            if (tall.IsWorked())
            {
                score += 1;
            }
        }
        Score = score;
        ScoreController.text = $"{Score} : Points";

    }
}
