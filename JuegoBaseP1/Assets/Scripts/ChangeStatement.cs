using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeStatement : MonoBehaviour
{
    public string loadName;
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
    public void OnTriggerEnter(Collider other)
    {        
        SceneManager.LoadSceneAsync(loadName);          
    }
    
}
