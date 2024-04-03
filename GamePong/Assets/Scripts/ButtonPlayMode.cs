using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonPlayMode : MonoBehaviour
{
    public GameObject racket2;
    public GameObject player2;

    public void goToTheGame()
    {
        if (this.gameObject.name == "ButtonPlayMode1")
        {
            SceneManager.LoadScene("Game");
            racket2.GetComponent<Racket2>().enabled = true; // Activar el script Racket2 para el modo jugador vs jugador
            player2.GetComponentInChildren<Text>().text = "Player Two";
        }
        else if (this.gameObject.name == "ButtonPlayMode2")
        {
            SceneManager.LoadScene("Game");
            racket2.GetComponent<Racket2IA>().enabled = true; // Activar el script Racket2IA para el modo jugador vs IA
            player2.GetComponentInChildren<Text>().text = "CPU";
        }
    }
}
