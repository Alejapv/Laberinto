using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Finale : MonoBehaviour
{
    
    public GameObject textoYouWin;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("¡Jugador llegó a la meta!"); 
            textoYouWin.SetActive(true); 
            Invoke("ReiniciarJuego", 10f); 
        }
    }

    void ReiniciarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

