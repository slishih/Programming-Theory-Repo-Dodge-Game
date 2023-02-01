using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerZ : MonoBehaviour
{
    public GameObject player;
    private float offset = -4;
    private Vector3 newPosition;


    // Update is called once per frame
    void LateUpdate()
    {
        newPosition = new Vector3(0,(float)6.6,(float)player.transform.position.z + offset);
        transform.position = newPosition;
    }
}
