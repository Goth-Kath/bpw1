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


    // Use this for initialization
    void Start()
    {
        text.text = actualtext[nummer];
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("e"))
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
