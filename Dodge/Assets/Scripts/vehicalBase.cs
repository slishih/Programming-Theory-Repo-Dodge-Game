using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicalBase : MonoBehaviour
{
    private float speed = 20.0f;
    
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }

}
