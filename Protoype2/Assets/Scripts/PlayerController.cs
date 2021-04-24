using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float xRange = 19.0f;

    public float speed = 10.0f;
    public GameObject projectilePrefab;
    public float projectileOffset;

    // Update is called once per frame
    void Update()
    {
        // left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // keep the player in bounds
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // launch a hamburger/food/projectile
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y + projectileOffset, transform.position.z), projectilePrefab.transform.rotation);
        }
    }
}