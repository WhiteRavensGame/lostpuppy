using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator codyAnimator;

    private int keysPressed = 0;
    public float movementSpeed;

    private float xVelocity;
    private float yVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            keysPressed += 1;
            yVelocity = movementSpeed;

            codyAnimator.SetBool("leftMove", false);
            codyAnimator.SetBool("rightMove", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            keysPressed += 1;
            yVelocity = -movementSpeed;

            codyAnimator.SetBool("rightMove", false);
            codyAnimator.SetBool("leftMove", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            keysPressed += 1;
            xVelocity = -movementSpeed;

            codyAnimator.SetBool("rightMove", false);
            codyAnimator.SetBool("leftMove", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            keysPressed += 1;
            xVelocity = movementSpeed;

            codyAnimator.SetBool("leftMove", false);
            codyAnimator.SetBool("rightMove", true);
        }

        //GetKeyUp
        if ((Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.W)))
        {
            yVelocity = 0;
        }

        if ((Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)))
        {
            xVelocity = 0;
        }

        if ((Input.GetKeyUp(KeyCode.S)) || (Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)))
        {
            keysPressed -= 1;

            codyAnimator.SetBool("leftMove", false);
            codyAnimator.SetBool("rightMove", false);

            if (keysPressed == 0)
            {
                yVelocity = 0;
                xVelocity = 0;
            }
        }

        //execution
        rb.velocity = new Vector2(xVelocity, yVelocity);

        //Debuging
        if (keysPressed > 4 || keysPressed < 0)
        {
            keysPressed = 0;
        }
    }
}
