using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrip_text : MonoBehaviour {

    public Text text;
    public string[] actualtext;
    private int nummer;
    public int endtext;
    public GameObject canvas;
    private bool RayBool;


    // Use this for initialization
    void Start()
    {
        text.text = actualtext[nummer];
    }

    void HitByRay()
    {

        if (RayBool == false)
        {
            RayBool = true;
        }
        if (RayBool == true)
        {

            Debug.Log("I was hit by a ray");
            RayBool = false;
        }

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("e") && RayBool == true)
            {
            print(nummer);

            
            nummer++;
            if (nummer >= endtext)
            {
                canvas.SetActive(false);
                nummer = 0;
                text.text = actualtext[nummer];
            }
            else
            {
                text.text = actualtext[nummer];
            }
        }

    }
}
