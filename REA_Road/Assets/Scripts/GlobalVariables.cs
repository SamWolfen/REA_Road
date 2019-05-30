using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

    public enum Context { Win, Lose, Quesiton, Menu, Play };
    public bool pause;
    public bool demoMode;


    //spawn/movement
    public float speed;
    public int tick = 0;




}
