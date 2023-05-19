using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public string loadSceneName;
    public Image GameOver;
    public TextMeshProUGUI DeathText;    
    public GameObject player;

    void Start()
    {
        GameOver.enabled = false;
        DeathText.enabled = false;
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(player);
            audioSource.Play();
            GameOver.enabled = true;
            DeathText.enabled = true;
        }        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            {             
                SceneManager.LoadSceneAsync(loadSceneName);  
            }
    }

}
