using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    MeshRenderer renderers;
    [SerializeField] GameObject punto;
    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        if(punto == null)
        {
            renderers.material.color = Color.blue;            
        }
    }
}
