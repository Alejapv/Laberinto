using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Finale : MonoBehaviour
{
    
    public GameObject textoYouWin;

    private void Start()
    {
        if (textoYouWin != null)
            textoYouWin.SetActive(false); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("¡Jugador llegó a la meta!");
            if (textoYouWin != null)
            {
                textoYouWin.SetActive(true); 
                Debug.Log("Texto activado correctamente.");
            }
            else
            {
                Debug.LogError("Error: `textoYouWin` no está asignado en el Inspector.");
            }
            Invoke("ReiniciarJuego", 10f); 
        }
    }

    void ReiniciarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

