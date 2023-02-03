using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicalBase : MonoBehaviour
{
    private float speed = 20.0f;

    private void Start()
    {
        InvokeRepeating("rotEnemy", (float).5, (float).5);
    }
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    public virtual void rotEnemy()
    {
 
    }
}
