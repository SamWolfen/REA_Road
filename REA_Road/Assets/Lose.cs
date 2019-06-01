using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public GameObject Global;

    public GameObject Score;



    // Start is called before the first frame update
    void OnEnable()
    {
        Score.GetComponent<Text>().text = "" + Global.GetComponent<GlobalVariables>().totalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        var scene = SceneManager.GetActiveScene();



        SceneManager.UnloadSceneAsync(SceneManager.GetSceneByBuildIndex(0));
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).name);
      
    }
}
