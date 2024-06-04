using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    //depricated currently, using fire.cs instead
    /*
    public int yBound = 10;
    public Movement controller;
    private bool doorActive = false;
    void OnTriggerEnter(Collider other)
    {
        //if the other object in the trigger is player & has key1, then door is activated
        if ((other.CompareTag("Player")))
        {
            if (controller.hasKey1 == true)
            {
                doorActive = true;
                Debug.Log("Door Activated");
            }
        }
    }

    private void FixedUpdate()
    {
        //if the door is activated, it slides downwards out of sight of player and despawns
        if (doorActive == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            //if y is below the boundary, object is deleted
            if (transform.position.y < yBound)
            {
                Destroy(gameObject);
            }

        }
    }*/
}
