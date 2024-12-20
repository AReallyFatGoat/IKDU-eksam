using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform transform;
    [SerializeField] private int speed;
    private Rigidbody rb;
    private Vector3 movement;
    public bool playing=true;
    void OnMovement(InputValue inputValue) // is called by "PlayerInput" component with its Movement actions input value (Vector2)
    {
        Vector2 input = inputValue.Get<Vector2>(); // Converts "inputvalue" to Vector2
        movement.x = input.x; // Turns 2D left-right -> 3D left-right 
        movement.z = input.y; // Turns 2D up-down -> 3D forward-back
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 
    void FixedUpdate()
    {
        if (!playing) return;
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z*speed); // Change player velocity x and z to movement * speed

    }
}
