using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject keyimage;
    public AudioSource musicsource;
    public AudioClip pickupitem;
    public AudioClip closetdoor;
    public GameObject closetcanvas;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        closetcanvas.SetActive(false);

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Main Menu");
        }
        
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "drawer")
            {
                dresseropen.SetActive(true);
                Destroy(dresserclosed);
                keybool = true;
                musicsource.PlayOneShot(pickupitem);

            }
            if (keybool == true){
                keyimage.SetActive(true);
            }
            else{
                keyimage.SetActive(false);
            }
            if (hit.transform.tag == "closet")
            {
                closetcanvas.SetActive(true);
            }
            if (Input.GetMouseButtonDown(0) && hit.transform.tag =="closet" && keybool == true)
            {
                closetopen.SetActive(true);
                Destroy(closetclosed);
                keybool = false;
                musicsource.PlayOneShot(closetdoor);
            }

            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "painting")
            {
                musicsource.PlayOneShot(closetdoor);
                SceneManager.LoadScene("PirateShip");
            }
          
       




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

