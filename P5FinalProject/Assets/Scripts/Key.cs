using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Movement controller;

    private void OnTriggerEnter(Collider other)
    {
        //if other collision is player, set gotKey to true and despawn
        if (other.CompareTag("Player"))
        {
            controller.gotKey();
            Destroy(gameObject);
        }
    }
}
