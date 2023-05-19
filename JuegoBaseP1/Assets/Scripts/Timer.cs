using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public AudioSource audioSource;
    //public AudioSource clockSound;
    public string loadSceneName;
    public float timer = 0;
    public TextMeshProUGUI text;
    public Image GameOver;
    public TextMeshProUGUI DeathText;    
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.enabled = false;
        DeathText.enabled = false;        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 
        text.text = ""+ timer.ToString("f1");
        // if (timer <= 10)
        // {
        //     clockSound.Play();
        // }
        if (timer <= 0)
        {
            timer = 0;
            Destroy(player);
            audioSource.Play();
            GameOver.enabled = true;
            DeathText.enabled = true;
            if(Input.GetKeyDown(KeyCode.Space))
            {             
                SceneManager.LoadSceneAsync(loadSceneName);  
            }
        }
        
    }
}
