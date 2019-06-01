using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    public GameObject Global;


  public void clicked()
    {
        Debug.Log("clikd");

        if (gameObject.tag == "true")
        {
            Global.GetComponent<GlobalVariables>().Answer(true);
        }
        else
        {
            Global.GetComponent<GlobalVariables>().Answer(false);
        }
    }
}
