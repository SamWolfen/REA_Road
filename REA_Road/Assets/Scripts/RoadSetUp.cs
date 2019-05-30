using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// randomly assigns which vehicles are used
/// </summary>
public class RoadSetUp : MonoBehaviour
{
    int rnd;
    Random random;

    public GameObject Spawner1, Spawner2, Deconstructor1, Deconstructor2, Rhino, Rhino2, Bus, Bus2, Ute, U2;

    private void OnEnable()
    {
        rnd = Random.Range(0, 3);
        Debug.Log("Rolled: " + rnd);
        switch (rnd)
        {
            case 0:
                {

                    Rhino.SetActive(true);
                    Rhino.transform.position = Spawner1.transform.position;

                    break;
                }
            case 1:
                {
                    Bus.SetActive(true);
                    Bus.transform.position = Spawner1.transform.position;

                    break;
                }
            case 2:
                {
                    Ute.SetActive(true);
                    Ute.transform.position = Spawner1.transform.position;

                    break;
                }
        }

        rnd = Random.Range(0, 3);
        switch (rnd)
        {
            case 0:
                {

                    Rhino2.SetActive(true);
                    Rhino2.transform.position = Spawner2.transform.position;

                    break;
                }
            case 1:
                {
                    Bus2.SetActive(true);
                    Bus2.transform.position = Spawner2.transform.position;

                    break;
                }
            case 2:
                {
                    U2.SetActive(true);
                    U2.transform.position = Spawner2.transform.position;

                    break;
                }
        }
    }

    public void ReRoll(GameObject Decon, GameObject Caller)
    {

        rnd = Random.Range(0, 3);
        Debug.Log("Rolled: " + rnd);

        Caller.SetActive(false);

        if (Decon.name == Deconstructor1.name)
        {


            switch (rnd)
            {
                case 0:
                    {

                        Rhino.SetActive(true);
                        Rhino.transform.position = Spawner1.transform.position;

                        break;
                    }
                case 1:
                    {
                        Bus.SetActive(true);
                        Bus.transform.position = Spawner1.transform.position;

                        break;
                    }
                case 2:
                    {
                        Ute.SetActive(true);
                        Ute.transform.position = Spawner1.transform.position;

                        break;
                    }
            }

        }
        else
        {
            switch (rnd)
            {
                case 0:
                    {

                        Rhino2.SetActive(true);
                        Rhino2.transform.position = Spawner2.transform.position;

                        break;
                    }
                case 1:
                    {
                        Bus2.SetActive(true);
                        Bus2.transform.position = Spawner2.transform.position;

                        break;
                    }
                case 2:
                    {
                        U2.SetActive(true);
                        U2.transform.position = Spawner2.transform.position;

                        break;
                    }
            }


        }



        

    }
}

