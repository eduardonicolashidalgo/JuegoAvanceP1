using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSceneController : MonoBehaviour
{
    public string sceneLoadName;
    private AsyncOperation loadAsync;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            loadAsync = SceneManager.LoadSceneAsync(sceneLoadName);
        }
        
    }
}
