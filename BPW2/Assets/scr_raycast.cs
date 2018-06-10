using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_raycast : MonoBehaviour
{

    public float rayDistance;
    private Behaviour halolight;
    
    // Use this for initialization
    void Start()
    {
        Behaviour halolight = (Behaviour)GetComponent("Halo");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (hit.transform.tag == "textitem")
            {
               
                halolight.enabled = true;
            }
            if (hit.transform.tag == "bleh")
            {
                Destroy(hit.transform.gameObject);
            }

        }
    }
}

