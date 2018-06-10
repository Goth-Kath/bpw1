using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_move : MonoBehaviour {

    private float rotationSpeedY;
    public float mouseSensitivity;
    private bool playerUp;
    private bool playerDown;
    private bool playerRight;
    private bool playerLeft;
    public float strafeSpeed;
    public float movementSpeed;



	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        rotationSpeedY += Input.GetAxis("Mouse X") * mouseSensitivity;

        transform.rotation = Quaternion.Euler(0, rotationSpeedY, 0);

        if (Input.GetKey("w"))
        {
            playerUp = true;

        }
        else
        {
            playerUp = false;
        }

        if (Input.GetKey("s"))
        {
            playerDown = true;

        }
        else
        {
            playerDown = false;
        }

        if (Input.GetKey("a"))
        {
            playerLeft = true;

        }
        else
        {
            playerLeft = false;
        }

        if (Input.GetKey("d"))
        {
            playerRight = true;

        }
        else
        {
            playerRight = false;
        }

    }


        private void FixedUpdate()
        {
            if (playerUp)
            {
                transform.position += transform.forward * Time.deltaTime * movementSpeed;
            }

            if (playerDown)
            {
                transform.position -= transform.forward * Time.deltaTime * movementSpeed;
            }

            if (playerLeft)
            {
                transform.position -= transform.right * Time.deltaTime * strafeSpeed;
            }

            if (playerRight)
            {
                transform.position += transform.right * Time.deltaTime * strafeSpeed;
            }
        }


    }
