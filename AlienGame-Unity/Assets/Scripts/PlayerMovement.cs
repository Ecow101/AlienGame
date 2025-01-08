using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    public float speed = 4f;

    // Jump speed setting, in meters/second
    public float jumpSpeed = 10f;

    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

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

        newvelocity.x = -speed;

        physicsBody.velocity = newvelocity;
    }

    public void MoveRight()
    {
        //physicsBody.velocity.x = 1;

        // make a variable to hold our velocity
        // get the velocity from the rigidbody
        Vector2 newvelocity = physicsBody.velocity;

        newvelocity.x = speed;

        physicsBody.velocity = newvelocity;
    }

    public void Jump()
    {

        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            // make a variable to hold our velocity and get the
            // current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;

            //Set our velocity to move in the positive y (up) direction
            newVelocity.y = jumpSpeed;

            //Update our physics component's velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }

    }

}
