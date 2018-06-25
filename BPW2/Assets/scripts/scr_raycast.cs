using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scr_raycast : MonoBehaviour
{

    public float rayDistance;
    public Behaviour currentHalo;
    public scrip_text currentText;
    public Text textComponent; 
    public GameObject canvas;
   
    public GameObject closetclosed;
    public GameObject closetopen;
    private bool keybool;
    public GameObject dresseropen;
    public GameObject dresserclosed;
    
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
            //Halo Behaviour
            if (currentHalo != null)
            {
                currentHalo.enabled = false;
            }
            Behaviour haloBehaviour = (Behaviour)hit.collider.GetComponent("Halo");

            if (haloBehaviour != null)
            {
                haloBehaviour.enabled = true;
                currentHalo = haloBehaviour;
            }

            //Text laten zien
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.R))
            {
                currentText = hit.collider.GetComponent<scrip_text>();
                if (currentText != null)
                {
                    canvas.SetActive(true);

                    currentText.Reset();
                    ShowText();
                }

            }
        }
        else
        {
            DontShowCanvasAndResetText();
        }
        if (Input.GetKeyDown(KeyCode.E) && currentText != null)
        {
            ShowText();
        }


    }

    void DontShowCanvasAndResetText()
    {
        if(currentText != null)
        {
            currentText.Reset();
        }
        
        currentText = null;
        canvas.SetActive(false);
    }

    void ShowText()
    {
        string text = currentText.GetNextText();
        if (text != "")
        {
            textComponent.text = text;
        }
        else
        {
            DontShowCanvasAndResetText();
        }
    }
}

