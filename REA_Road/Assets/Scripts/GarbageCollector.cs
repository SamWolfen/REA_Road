using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Deactivates objects that come in to contact with it. Loss condition for player??
/// </summary>
public class GarbageCollector : MonoBehaviour
{
    public GameObject Global;
    public GameObject GarbageCreator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Click")
        {
            //Debug.Log("tick");
            GarbageCreator.GetComponent<GarbageCreator>().Tick();
        }


        //collect and disable object
        other.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
       


        //collect and disable object
        collision.gameObject.SetActive(false);
    }
}
