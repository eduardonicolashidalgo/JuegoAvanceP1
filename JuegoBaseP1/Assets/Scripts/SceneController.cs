using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public string sceneLoadName;
    public TextMeshProUGUI textProgress;
    public TextMeshProUGUI textMessage;
    public Slider sliderProgress;
    public float currentPercent;
    private AsyncOperation loadAsync;

    public void LoadSceneButton()
    {
        StartCoroutine(LoadScene(sceneLoadName));
    }
    public IEnumerator LoadScene(string nameToLoad)
    {
        textProgress.text = "Loading.. 00%";
        loadAsync = SceneManager.LoadSceneAsync(nameToLoad);
        loadAsync.allowSceneActivation = false;
        while(!loadAsync.isDone)
        {
            currentPercent = loadAsync.progress * 100 / 0.9f;
            textProgress.text = "Loading.. "+currentPercent.ToString("00")+"%";
            yield return null;
        }
    }

    private void Update()
    {
        sliderProgress.value = Mathf.MoveTowards(sliderProgress.value, currentPercent, 30* Time.deltaTime);
        if(loadAsync != null && currentPercent >= 100)
        {
            textMessage.text = "Presiona Espacio para continuar";
            if(Input.GetKeyDown(KeyCode.Space))
            {
                loadAsync.allowSceneActivation = true;
            }
        }
    }
}
