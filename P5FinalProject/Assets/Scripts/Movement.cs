using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool hasBucket = false;

    void FixedUpdate()
    {
        //movement
        //uses input manager to get a vector3 and translates to said vector. Rotation follows movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        transform.Translate(movement.normalized * 0.1f, Space.World);
        transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
    }


    public void gotKey()
    {
        //logs in console that key has been collected, and sets bool to true
        Debug.Log("This works");
        hasBucket = true;
    }
}
