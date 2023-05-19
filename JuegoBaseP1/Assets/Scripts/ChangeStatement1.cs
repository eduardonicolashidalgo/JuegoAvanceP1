using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeStatement1 : MonoBehaviour
{
    MeshRenderer renderers;
    BoxCollider boxCollider;
    [SerializeField] GameObject punto;
    
    void Start()
    {        
        renderers = GetComponent<MeshRenderer>(); 
        boxCollider = GetComponent<BoxCollider>();
        renderers.enabled = false;
        boxCollider.isTrigger = false;
    }

    void Update()
    {
        if(punto == null)
        {
            renderers.enabled = true;
            boxCollider.isTrigger = true;              
        }
    }    

    
}
