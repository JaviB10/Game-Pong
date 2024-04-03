using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControl : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreText1;
    public GameObject scoreText2;

    public int scoreWinner;

    public GameObject titleWinner;
    public GameObject player2;
    public GameObject sound;

    AudioSource[] audioSources;

    void Start()
    {
        // Inicializar audioSources dentro del método Start
        audioSources = sound.GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.scorePlayer2 >= this.scoreWinner)
        {
            if(player2.GetComponentInChildren<Text>().text == "Player Two")
            {
                titleWinner.GetComponentInChildren<Text>().text = "WINNER PLAYER TWO";
                audioSources[1].enabled = true;
            }
            else if(player2.GetComponentInChildren<Text>().text == "CPU")
            {
                titleWinner.GetComponentInChildren<Text>().text = "GAME OVER";
                audioSources[0].enabled = true;
            }
            SceneManager.LoadScene("GameOver");
        }
        else if(this.scorePlayer1 >= this.scoreWinner)
        {
            titleWinner.GetComponentInChildren<Text>().text = "WINNER PLAYER ONE";
            audioSources[1].enabled = true;
            SceneManager.LoadScene("GameOver");

        }

    }

    private void FixedUpdate()
    {
        Text tagPlayer1 = this.scoreText1.GetComponent<Text>();
        tagPlayer1.text = this.scorePlayer1.ToString();

        Text tagPlayer2 = this.scoreText2.GetComponent<Text>();
        tagPlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }
}
