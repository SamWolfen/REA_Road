using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleInput : MonoBehaviour
{
    float coolDown;
    public bool ready = true;
    public float tile;
    Vector3 nextPlayerPos;
    Vector3 lastPlayerPos;
    public float playerSpeed;
    float deltaSpeed;

    public GameObject Global;
    

    private IEnumerator coroutine;

    enum Swipe
    {
        Up, Down, Left, Right, None
    }

    enum Facing
    {
        Up, Down, Left, Right, None
    }

    Swipe swipe;
    Facing facing;

    // Start is called before the first frame update
    void Start()
    {
        ready = true;
        coroutine = Hop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Global.GetComponent<GlobalVariables>().pause)
        {
            //Get the input from SwipeMovement.cs
            if (GetComponent<SwipeMovement>().swipeU)
            {
                swipe = Swipe.Up;
            }

            if (GetComponent<SwipeMovement>().swipeD)
            {
                swipe = Swipe.Down;
            }

            if (GetComponent<SwipeMovement>().swipeL)
            {
                swipe = Swipe.Left;
            }

            if (GetComponent<SwipeMovement>().swipeR)
            {
                swipe = Swipe.Right;
            }

            if ((!GetComponent<SwipeMovement>().swipeU) && (!GetComponent<SwipeMovement>().swipeD) && (!GetComponent<SwipeMovement>().swipeL) && (!GetComponent<SwipeMovement>().swipeR))
            {
                swipe = Swipe.None;
            }

            //process input
            if (ready)
            {
                MovePlayer(swipe);
            }
        }
    }

    void MovePlayer(Swipe swp)
    {
        Vector3 pos = gameObject.transform.position;
       

        if (swp != Swipe.None)
        {
            ready = false;

            switch (swp)
            {
                case Swipe.Up:
                    {
                        nextPlayerPos = new Vector3(pos.x, pos.y, pos.z + tile);
                        break;
                    }

                case Swipe.Down:
                    {
                        nextPlayerPos = new Vector3(pos.x, pos.y, pos.z - tile);
                        break;
                    }

                case Swipe.Left:
                    {
                        nextPlayerPos = new Vector3(pos.x - tile, pos.y, pos.z);
                        break;
                    }

                case Swipe.Right:
                    {
                        nextPlayerPos = new Vector3(pos.x + tile, pos.y, pos.z);
                        break;
                    }
            }

            transform.LookAt(nextPlayerPos);
            StartCoroutine(Hop());
        }



    }

    IEnumerator Hop()
    {
        bool upward = true;
        float i = 0;
        //Debug.Log("Hop started");
        
        if ((nextPlayerPos.x > 5) || (nextPlayerPos.x < -4.5))
        {
            nextPlayerPos.x = transform.position.x;
        }

        while (!ready)
        {
            //Debug.Log("loop hop");

            deltaSpeed = playerSpeed * Time.deltaTime;

            //transform.position = new Vector3(transform.position.x, Mathf.Sin(i), transform.position.z);
            
            //i += tile / 10;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(nextPlayerPos.x, transform.position.y, nextPlayerPos.z), deltaSpeed);

            if (upward)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, nextPlayerPos.y + tile / 2, transform.position.z), deltaSpeed);
                if (transform.position.y  >= nextPlayerPos.y + tile/2)
                {
                    upward = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, nextPlayerPos.y, transform.position.z), deltaSpeed);
            }

            if ((transform.position.x == nextPlayerPos.x) && (transform.position.z == nextPlayerPos.z) && (transform.position.y == nextPlayerPos.y))
            {
                ready = true;
            }

            yield return new WaitForFixedUpdate();

        }




    }

}
