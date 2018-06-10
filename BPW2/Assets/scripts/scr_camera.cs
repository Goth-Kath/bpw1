using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camera : MonoBehaviour {


    private float rotationSpeedX;

    public float mouseSensitivity;
    public GameObject menuu;

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            menuu.SetActive(false);
        }
        if (Input.GetKeyDown("q"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        rotationSpeedX -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.rotation = Quaternion.Euler(rotationSpeedX, transform.eulerAngles.y, transform.eulerAngles.z);

    }

}
