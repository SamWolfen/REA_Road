using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public GameObject Global;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GeneralCollision(collision.gameObject);
        //Debug.Log("player touch collider: " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        GeneralCollision(other.gameObject);
        //Debug.Log("player touch trigger: " + other.gameObject.name);
    }

    private void GeneralCollision(GameObject col)
    {
        Debug.Log("Col type:" + col.tag);

        switch (col.tag)
        {
            case "Hazard":
                {
                    //GetComponent<Rigidbody>().useGravity = true;


                    //col.GetComponent<Rigidbody>().useGravity = true;
                    col.GetComponent<Rigidbody>().isKinematic = false;
                    col.GetComponent<MeshCollider>().isTrigger = false;

                    GetComponent<Rigidbody>().isKinematic = false;

                    //lose
                    Global.GetComponent<GlobalVariables>().context = GlobalVariables.Context.Lose;
                    Global.GetComponent<GlobalVariables>().UpdateContext();

                    break;
                }

            case "Debuff":
                {
                    //type?

                    break;
                }

            case "Buff":
                {
                    //type?
                    break;
                }

            case "Coin":
                {
                    Global.GetComponent<GlobalVariables>().score++;
                    //Global.GetComponent<GlobalVariables>().UpdateScore();
                    Debug.Log("Got Coin");
                    col.SetActive(false);
                    break;
                }

            case "Question":
                {
                    //Global.GetComponent<GlobalVariables>().pause = true;
                    Global.GetComponent<GlobalVariables>().context = GlobalVariables.Context.Question;
                    Global.GetComponent<GlobalVariables>().UpdateContext();
                    break;
                }
        }
    }
}
