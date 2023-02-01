using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    //private GameManager gameManager; 
    private float speed = 8.0f;
    private float turnSpeed = 8.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (transform.position.z > -9.5)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }
        else
        {
            transform.Translate(0, 0, (float).1);
        }

        if (transform.position.x > -7.5 & transform.position.x < 7.5)
        {
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
        if (transform.position.x < -7.5)
        {
            transform.Translate((float).1, 0, 0);
        }
        if (transform.position.x > 7.5)
        {
            transform.Translate((float)-.1, 0, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            //gameManager.Win();
            Debug.Log("You Win!");
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Hit");
        }
    }
}
