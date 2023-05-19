using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectHit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.tag == "Player")
        // {
        // GetComponent<MeshRenderer>().material.color = Color.blue;
        // gameObject.tag = "Hit";
        // }

        // if(other.gameObject.CompareTag("ObjetoDestruible"))
        // {
        //     Destroy(gameObject);
        // }
    }
}
