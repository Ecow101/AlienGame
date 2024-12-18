using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

    // awake is called before start
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //physicsBody.velocity.x = -1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody
        Vector2 newvelocity = physicsBody.velocity;

        newvelocity.x = -1;

        physicsBody.velocity = newvelocity;
    }

    public void MoveRight()
    {
        //physicsBody.velocity.x = 1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody
        Vector2 newvelocity = physicsBody.velocity;

        newvelocity.x = 1;

        physicsBody.velocity = newvelocity;
    }

}
