using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2IA : MonoBehaviour
{
    public float moveSpeed;
    public GameObject ball;

    private void FixedUpdate()
    {
        if(MathF.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if(transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;
            }
           
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
