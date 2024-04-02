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

    // Update is called once per frame
    void Update()
    {
        if(this.scorePlayer1 >= this.scoreWinner || this.scorePlayer2 >= this.scoreWinner)
        {
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
