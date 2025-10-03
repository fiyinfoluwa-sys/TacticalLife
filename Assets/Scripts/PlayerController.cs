using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Player movement speed

    // Update is called once per frame
    void Update()
    {
        // Get input from keyboard
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Move the player
        transform.position += new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
    }
}
