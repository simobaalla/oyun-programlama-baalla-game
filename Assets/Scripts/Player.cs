using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float playerSp;
    private Rigidbody2D rb;
    private Vector2 playerDr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical"); 

        if (directionY == 0f && Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began || t.phase == TouchPhase.Stationary || t.phase == TouchPhase.Moved)
            {
             
                if (t.position.y > Screen.height / 2f)
                {
                    directionY = 1f;
                }
             
                else
                {
                    directionY = -1f;
                }
            }
        }

        playerDr = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, playerDr.y * playerSp);
    }
}
