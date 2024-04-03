using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    public MoveBall moveBall;
    public ScoreControl scoreControl;

    public GameObject racket1;
    public GameObject racket2;

    void CollisionWithRacket(Collision2D c)
    {
        Vector3 positionBall = this.transform.position;
        Vector3 positionRacket = c.gameObject.transform.position;
        float tallRacket = c.collider.bounds.size.y;

        float x;

        if(c.gameObject.name == "Racket1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (positionBall.y - positionRacket.y) / tallRacket;

        this.moveBall.IncreaseHitCounter();
        this.moveBall.MovementBall(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.CollisionWithRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            this.scoreControl.GoalPlayer2();
            StartCoroutine(this.moveBall.StartBall(true));
            racket1.transform.localPosition = new Vector2(-600, 0);
            racket2.transform.localPosition = new Vector2(600, 0);
        }
        else if(collision.gameObject.name == "WallRight")
        {
            this.scoreControl.GoalPlayer1();
            StartCoroutine(this.moveBall.StartBall(false));
            racket1.transform.localPosition = new Vector2(-600, 0);
            racket2.transform.localPosition = new Vector2(600, 0);
        }
    }
}
