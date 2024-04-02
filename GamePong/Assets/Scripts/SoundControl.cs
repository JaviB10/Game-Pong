using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource soundRacket;
    public AudioSource soundWall;
    public AudioSource soundWallGoal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.soundRacket.Play();
        }
        else if(collision.gameObject.name == "WallUp" || collision.gameObject.name == "WallDown")
        {
            this.soundWall.Play();
        }
        else
        {
            this.soundWallGoal.Play();
        }
    }
}
