using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerSpeed;

    private bool gameOver = false;
    private Rigidbody playerRb;
    private float moveLeft = -2.2f;
    private float moveRight = 2.2f;
    private float jump = 2.7f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // this is where the player can control, using key A, S, D, Space.
        // A to move left
        // S to slide down
        // D to move right
        // Space to jump
        // I will of course add force into this
        playerRb.transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
        if (Input.GetKeyDown(KeyCode.A) && !gameOver)
        {
            playerRb.transform.position = new Vector3(playerRb.transform.position.x + moveLeft, playerRb.transform.position.y, playerRb.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && !gameOver)
        {
            playerRb.transform.position = new Vector3(playerRb.transform.position.x + moveRight, playerRb.transform.position.y, playerRb.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            playerRb.transform.position = new Vector3(playerRb.transform.position.x, playerRb.transform.position.y + jump, playerRb.transform.position.z);
        }
    }

    private void CheckCollision()
    {
        // this is where I will check collision
        // if the player hit one of the obstacle the game is over and the tiger will eat the player
        // and gameOver = true;
        // if the player just slightly hit the obstacle, the player will slow down for a moment, and the tiger will get closer to the player
        // so basically the player get one more chance if he just hit the obstacle slightly
    }
}
