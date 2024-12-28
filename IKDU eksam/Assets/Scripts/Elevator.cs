using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 locationA;
    [SerializeField] private Vector3 locationB;
    [SerializeField] private Transform transform;
    private bool active = false;
    private bool locked = true;

    public void Unlock()
    {
        locked = false;
    }
     
    private void OnCollisionEnter(Collision collision) // Making it so that when elevator starts collision with gameObject tagged with "Player", active = true
    {
        if (collision.gameObject.tag != "Player") return;
        if (locked) return;
        active = true;
    }

    private void OnCollisionExit(Collision collision) // Making it so that when elevator stops collision with gameObject tagged with "Player", active = false
    {
        if (collision.gameObject.tag != "Player") return;
        active = false;
    }
    void Start() // sets Elevators position to start location "locationA"
    {
        transform.position = locationA;

    }
    void Update()
    {
        if (active) //if active = true
        {
            if (transform.position.y >= locationB.y) // if elevators position is = or above end location "locationB"
            {
                transform.position = new Vector3(transform.position.x, locationB.y, transform.position.z); // sets elevators y position to "LocationB"
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z); // Moves up
            }

        }
        else if (!active) //if active = false
        {
            if (transform.position.y <= locationA.y) // if elevators position is = or below end location "locationA"
            {
                transform.position = new Vector3(transform.position.x, locationA.y, transform.position.z); // sets elevators y position to "LocationA"
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z); // Moves down
            }
        }
    }
}
