using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private PickupsManager manager;
    [SerializeField] private Transform transform;
    [SerializeField] private Vector3 rotationSpeed;
    public int floor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.AddCoin(this);
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        manager = FindAnyObjectByType<PickupsManager>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(rotationSpeed);
    }
}
