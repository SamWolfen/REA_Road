using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject Global;

    public GameObject[] Characters;
    public GameObject Intro;
    public GameObject Name;
    public GameObject Question;

    public GameObject Ans1;
    public GameObject Ans2;
    public GameObject Ans3;

     public GameObject Ans1text;
    public GameObject Ans2text;
    public GameObject Ans3text;



    string strIntro;
    string strName;
    string strQuestion;
    string strAns1 = "";
    string strAns2 = "";
    string strAns3 = "";


    int currentQuestion;


    private void OnEnable()
    {
        currentQuestion = Global.GetComponent<GlobalVariables>().currentQuestion;


        Ans2.SetActive(false);
        Ans3.SetActive(false);

        Ans1.tag = "false";
        Ans2.tag = "false";
        Ans3.tag = "false";

        int i = 0;

        while(i< Characters.Length)
        {
            try { 
            Characters[i].SetActive(false);
            }
            catch
            {
                //really ought to put something here :P
            }
            i++;
        }

        Characters[currentQuestion].SetActive(true);



        switch (currentQuestion)
        {
            case 0:
                {
                    //Nigel intro
                    strIntro = "Hi, I'm the Chief Inventor at REA Group!";
                    strName = "Nigel Dalton";
                    strQuestion = "We’d love for you to come and explore REA." + "\r\n" + "Are you ready to start your journey?" + "\r\n" + "Make sure you stop and meet the crew!";
                    strAns1 = "I'm ready!";

                    Ans1.tag = "true";


                    break;
                }
            case 1:
                {
                    //Richard intro
                    strIntro = "Welcome! I'm one of the barista’s here at REA’s Community Cafe!";
                    strName = "Richard";
                    strQuestion = "Here we raise a bunch of money for our 6 community partners each year! " +  "\r\n" + "How much money have we raised for these charity partners in the last 12 months?";
                    strAns1 = "$54,000";
                    strAns2 = "$66,000";
                    strAns3 = "$98,000"; //answer

                    Ans2.SetActive(true);
                    Ans3.SetActive(true);

                    Ans3.tag = "true";


                    break;
                }
            case 2:
                {
                    //Tammy intro
                    strIntro = "Congrats! You’ve reached REA Labs!" + "\r\n" + "I'm an Imagineer at REA!";
                    strName = "Tammy";
                    strQuestion = "We actually have a lot more products than people realise! " + "\r\n" + "REA is a Polyglot environment when it comes to language choice for our many software systems." + "\r\n" + "Which languages do you think we have built the most products over the last 12 months?";
                    strAns1 = "Ruby";
                    strAns2 = "SCALA";//Answer
                    strAns3 = "Javascript";

                    Ans2.SetActive(true);
                    Ans3.SetActive(true);
                    Ans2.tag = "true";


                    break;
                }
            case 3:
                {
                    //Dog intro
                    strIntro = "Woof! Welcome to The Garage! ";
                    strName = "Maverick";
                    strQuestion = "REA Group is one of the great Australian start-up success stories" + "\r\n" +  "We have 3 hackathons (REAio) each year to honour these origins and inspire inventorship." +"\r\n"+ "How many ideas have been shipped from these Hackathons?";
                    strAns1 = "33";
                    strAns2 = "12";
                    strAns3 = "66"; //answer


                    Ans2.SetActive(true);
                    Ans3.SetActive(true);

                    Ans3.tag = "true";


                    break;
                }



        }



        Intro.GetComponent<Text>().text = strIntro;
        Name.GetComponent<Text>().text = strName;
        Question.GetComponent<Text>().text = strQuestion;

        Ans1text.GetComponent<Text>().text = strAns1;
        Ans2text.GetComponent<Text>().text = strAns2;
        Ans3text.GetComponent<Text>().text = strAns3;
    }


}
