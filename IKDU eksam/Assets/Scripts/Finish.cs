using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject ui;
    [SerializeField] private PlayerMovement player;
    private void OnTriggerEnter(Collider other)
    {
        ui.SetActive(true);
        player.playing = false;
    }
    void Start()
    {
        ui.SetActive(false);
    }

  
}
