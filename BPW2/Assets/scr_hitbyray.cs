using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_hitbyray : MonoBehaviour {

    private bool RayBool;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void HitByRay() {

        if (RayBool == false) {
            RayBool = true;
        }
        if (RayBool == true)
        {

            Debug.Log("I was hit by a ray");
            RayBool = false;
        }
        
    }
   
}
