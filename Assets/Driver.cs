using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private int moveSpeed;
    private int steerSpeed = 250;
    private int slowSpeed = 15;
    private int boostSpeed = 25;

    private void Start() {
        moveSpeed = slowSpeed;
    }

    void Update() {
        float deltaTime = Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            // boost speed
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
