using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    //Hi person finishing this project, sorry its a bit of a mess, but this is a hack project after all :P ~ Sam

    public enum Context { Win, Lose, Question, Menu, Play, Title };
    public Context context;
    public bool pause;
    public bool demoMode;
    public int score = 0;
    public int currentQuestion = 0;
    public int totalScore = 0;
    public GameObject ScoreDisplay;
    public GameObject Question;
    public GameObject Menu;
    public GameObject Title;
    public GameObject WinScreen;
    public GameObject LossScreen;
    public GameObject CorrectScreen;
    public GameObject WrongScreen;
    //spawn/movement


    public float speed;
    public int tick = 0;

    private void Start()
    {
        
        //context = Context.Title;
        UpdateContext();
    }

    public void UpdateContext()
    {
        switch (context)
        {
            case Context.Title:
                {
                    Question.SetActive(false);
                    WinScreen.SetActive(false);
                    LossScreen.SetActive(false);
                    Menu.SetActive(false);
                    pause = false;

                    break;
                }

            case Context.Question:
                {
                    pause = true;
                    Question.SetActive(true);
                    break;
                }
            case Context.Play:
                {
                    Question.SetActive(false);
                    
                    //WinScreen.SetActive(false);
                    //LossScreen.SetActive(false);

                    pause = false;
                    break;
                }
            case Context.Win:
                {
                    pause = true;
                    break;
                }
            case Context.Lose:
                {
                    pause = true;
                    LossScreen.SetActive(true);
                    break;
                }
        }
    }

    public void UpdateScore()
    {
        totalScore = score + tick;
        ScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "" + totalScore;
        ScoreDisplay.GetComponent<UnityEngine.UI.Text>().color = Color.black;
        if (currentQuestion >= 4)
        {
            //lose is neutral
            context = Context.Lose;
            UpdateContext();

        }
            
    }

    public void Answer(bool ans)
    {
        if (ans)
        {
            score = score + 10;
            Question.SetActive(false);
            UpdateScore();
            context = Context.Play;
            UpdateContext();
            currentQuestion++;

        }
        else
        {
            score = score - 10;
            UpdateScore();
            context = Context.Play;
            UpdateContext();
            currentQuestion++;
            ScoreDisplay.GetComponent<UnityEngine.UI.Text>().color = Color.red;
        }
    }
}
