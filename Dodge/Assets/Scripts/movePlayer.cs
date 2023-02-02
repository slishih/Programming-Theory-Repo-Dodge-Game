using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Applied to Player Character
public class movePlayer : MonoBehaviour
{
    public gameManager gameManager; 
    private float speed = 8.0f;
    private float turnSpeed = 8.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameActive == true)
        {
            //Get Input from Arrow keys 
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            //Applies Keypress to Player's Position, with boundary so cant go off camera.
            if (transform.position.x < -7.5)
            {
                transform.position = new Vector3((float)-7.5, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 7.5)
            {
                transform.position = new Vector3((float)7.5, transform.position.y, transform.position.z);
            }
            if (transform.position.z < -9.5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, (float)-9.5);
            }

            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        }

    }

    //Runs when collison detected
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            gameManager.Win();
            Debug.Log("You Win!");

        }
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
            gameManager.ReduceLives();
            ResetPlayerPos();
        }
    }

    private void ResetPlayerPos()
    {
        transform.position = new Vector3(0,(float).6,(float)-8.5);
    }
}
