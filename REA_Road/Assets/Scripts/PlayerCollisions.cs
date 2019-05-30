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
        switch (collision.gameObject.tag)
        {
            case "Hazard":
                {
                    GetComponent<Rigidbody>().useGravity = true;
                    GetComponent<Rigidbody>().isKinematic = false;


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
                    Debug.Log("Got Coin");
                    collision.gameObject.SetActive(false);
                    break;
                }
        }
    }
}
