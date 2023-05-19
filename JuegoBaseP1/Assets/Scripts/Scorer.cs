using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.tag != "Hit")
        // hits++;
        // Debug.Log("You hit " + hits+ " times");        
    }

        private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Escena"))
        {
            SceneManager.LoadScene(1);
        }
    }
}

