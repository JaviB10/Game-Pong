using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void goToTheGame()
    {
        SceneManager.LoadScene("Game");
    }
}
