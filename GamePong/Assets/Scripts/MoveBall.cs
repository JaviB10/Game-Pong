using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float moveSpeed;
    public float speedMultiplier;
    public float speedMax;

    int hitCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool player1 = true)
    {
        this.hitCounter = 0;

        yield return new WaitForSeconds(2);

        if (player1)
        {
            this.MovementBall(new Vector2(-1, 0));
        }
        else
        {
            this.MovementBall(new Vector2(-1, 0));
        }
    }

    public void MovementBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.moveSpeed + this.hitCounter * speedMultiplier;

        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.speedMultiplier <= this.speedMax)
        {
            this.hitCounter++;
        }
    }
}
