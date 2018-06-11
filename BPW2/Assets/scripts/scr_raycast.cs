using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_raycast : MonoBehaviour
{

    public float rayDistance;
    [SerializeField]
    public Behaviour halolight;
    public GameObject canvas;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            halolight.enabled = false;

            if (hit.transform.tag == "a")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                    halolight.enabled = true;
            }
       

        }
    }
}

