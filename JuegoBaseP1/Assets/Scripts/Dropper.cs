using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderers;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 6f;
    // Start is called before the first frame update
    void Start()
    {        
        rigidBody = GetComponent<Rigidbody>();
        renderers = GetComponent<MeshRenderer>();
        renderers.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update the time
    void Update()
    {
        //Time.time show us the time, this can be implemented on the screen as a timer
        if(Time.time > timeToWait)
        {
            renderers.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
