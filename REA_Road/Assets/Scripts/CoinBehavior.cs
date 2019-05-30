using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    Rigidbody r_Body;

    private void Start()
    {
        r_Body = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        r_Body = GetComponent<Rigidbody>();
        r_Body.angularVelocity = new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));



        r_Body.velocity = new Vector3(0, 0, 0);

       
    }
}
