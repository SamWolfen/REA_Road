using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

    public enum Context { Win, Lose, Quesiton, Menu, Play };
    public bool pause;
    public bool demoMode;
    public int score = 0;
    public int totalScore = 0;
    public GameObject ScoreDisplay;
    //spawn/movement
    public float speed;
    public int tick = 0;

    private void FixedUpdate()
    {
        totalScore = score + tick;
    }


}
