using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
                SceneManager.UnloadSceneAsync("Pause");
            }
            else
            {
                Time.timeScale = 0f;
                SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
            }
        }
    }
}
