using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public GameObject Target;
    public GameObject GlobalVariables;

    Vector3 initPlayerPos;
    float speed;
    float initSpeed;
    float deltaSpeed;



    private void Start()
    {
        initPlayerPos = Target.transform.position;
        initSpeed = speed = GlobalVariables.GetComponent<GlobalVariables>().speed;
    }

    private void FixedUpdate()
    {
        deltaSpeed = speed * Time.deltaTime;

        initPlayerPos.z += 0.5f * deltaSpeed;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (0.5f*deltaSpeed));


        if (initPlayerPos.z + 0.5f < Target.transform.position.z)
        {
            initPlayerPos.z += deltaSpeed;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2*(deltaSpeed));
        }

        if (initPlayerPos.z > Target.transform.position.z)
        {
            //initPlayerPos.z -= deltaSpeed;
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - deltaSpeed);
        }

        if (initPlayerPos.z == Target.transform.position.z)
        {
            speed = initSpeed;
        }


    }
}
