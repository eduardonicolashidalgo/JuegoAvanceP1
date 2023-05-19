using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyElement : MonoBehaviour
{
    public AudioSource audioSource;
    private bool ObjetoDestruido = false;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            audioSource.Play();
            Debug.Log("Object Destoyed");
        }        
    }
}
