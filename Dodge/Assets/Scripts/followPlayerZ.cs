using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Applied to Camera
public class followPlayerZ : MonoBehaviour
{
    public GameObject player;
    private float offset = -4;
    private Vector3 newPosition;

    void LateUpdate()
    {
        //Gets Players Position Z and applies it to camera
        newPosition = new Vector3(0,(float)6.6,(float)player.transform.position.z + offset);
        transform.position = newPosition;
    }
}
