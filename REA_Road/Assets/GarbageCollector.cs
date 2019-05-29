using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Deactivates objects that come in to contact with it. Loss condition for player??
/// </summary>
public class GarbageCollector : MonoBehaviour
{
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
        collision.gameObject.SetActive(false);
    }
}
