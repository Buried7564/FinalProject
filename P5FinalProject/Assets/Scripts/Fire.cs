using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private Movement controller;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private GameObject Collider;

    void OnTriggerEnter(Collider other)
    {
        //if the other object is the player, pause fire particles and disable the collider blocking the path
        if ((other.CompareTag("Player")))
        {
            if (controller.hasBucket == true)
            {
                particles.Stop();
                Collider.SetActive(false);
            }
        }
    }
}
