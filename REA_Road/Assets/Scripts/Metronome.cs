using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    public GameObject ClickPool;
    public GameObject Global;
    int poolSize;
    int nextClick;
    int clickRate;
    Vector3 lastPos;

    private void Start()
    {
        poolSize = ClickPool.GetComponent<PoolGenerator>().PoolObjectList.Capacity;
        lastPos = transform.position;
        nextClick = 0;
    }

    private void FixedUpdate()
    {
        if((transform.position.z - lastPos.z) >= 1)
        {
            //Debug.Log("Should click");

            Click();

            lastPos = transform.position;
        }
    }

    public void Click()
    {
        Global.GetComponent<GlobalVariables>().UpdateScore();

        if (nextClick >= poolSize)
        {
            nextClick = 0;
        }

        ClickPool.GetComponent<PoolGenerator>().PoolObjectList[nextClick].SetActive(true);
        ClickPool.GetComponent<PoolGenerator>().PoolObjectList[nextClick].transform.position = transform.position;
        nextClick++;
    }
}
