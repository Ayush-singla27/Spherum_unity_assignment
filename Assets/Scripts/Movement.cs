using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public bool useWASD = true;

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;
        float horizontalInputArrow = 0f;
        float verticalInputArrow = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInputArrow = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInputArrow = 1f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInputArrow = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInputArrow = -1f;
        }
        Vector3 movement;
        if (useWASD)
        {
             movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        }
        else
        {
             movement= new Vector3(horizontalInputArrow, 0f, verticalInputArrow) * speed * Time.deltaTime;
        }


        
        transform.Translate(movement);

    }
}
