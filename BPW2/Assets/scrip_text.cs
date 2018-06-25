using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrip_text : MonoBehaviour {


    public string[] actualtext;
    private int nummer;


    // Use this for initialization
    void Start()
    {

    }

    public void Reset()
    {
        nummer = 0;
    }

    public string GetNextText()
    {
        string result = "";
        if(nummer < actualtext.Length)
        {
            result = actualtext[nummer];
        }

        nummer++;
        return result;
    }

}
