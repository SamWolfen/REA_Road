using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCode : MonoBehaviour
{
    public GameObject Spawner, Deconstructor, Road;

    public int speed;

    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Deconstructor.transform.position, speed * Time.deltaTime);
        transform.LookAt(Deconstructor.transform);

        if (transform.position == Deconstructor.transform.position)
        {
            transform.position = Spawner.transform.position;
            Road.GetComponent<RoadSetUp>().ReRoll(Deconstructor, gameObject);
            
        }
    }
}
