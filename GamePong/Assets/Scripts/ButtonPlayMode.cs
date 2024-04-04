using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayMode : MonoBehaviour
{
    public void goToTheGame()
    {
        if (this.gameObject.name == "ButtonPlayMode1")
        {
            SceneManager.LoadScene("Game");
        }
        else if (this.gameObject.name == "ButtonPlayMode2")
        {
            SceneManager.LoadScene("Game");
        }
    }
}
