using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject camPos;
    private Vector3 newPos;
    [SerializeField] private int offsetUp = 10;
    [SerializeField] private int offsetZ = -2;

    void Update()
    {
        //updates camera on an offset to player position every 
        newPos = new Vector3(transform.position.x, transform.position.y+offsetUp, transform.position.z+offsetZ);
        camPos.transform.position = newPos;
    }
}
