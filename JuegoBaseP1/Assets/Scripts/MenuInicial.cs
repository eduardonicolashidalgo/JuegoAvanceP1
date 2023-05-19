using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Salir()
    {
        Debug.Log("SALIENDO DEL JUEGO...");
    }
}
