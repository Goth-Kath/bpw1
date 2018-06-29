using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_raycast2 : MonoBehaviour
{

    public float rayDistance;
    public Behaviour currentHalo;
    public scrip_text currentText;
    public Text textComponent;
    public GameObject canvas;

    
   

    public GameObject gold;
    public Canvas doorcanvas;
    public Canvas hatcanvas;
    public Canvas standcanvas;
    public GameObject hat;
    private bool hatbool;
    public GameObject goldimage;
    public GameObject hatimage;
    private bool goldbool;
    public Canvas endcanvas;
    public GameObject thankscanvas;
    public AudioSource musicsource;
    public AudioClip pickupitem;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        doorcanvas.enabled = false;
        hatcanvas.enabled = false;
        standcanvas.enabled = false;
        endcanvas.enabled = false;

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Main Menu");
        }


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            

            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "gold")
            {
                musicsource.PlayOneShot(pickupitem);
                Destroy(gold);
                goldimage.SetActive(true);
                goldbool = true;

            }

            if (hit.transform.tag == "door")
            {
                doorcanvas.enabled = true;
                if (hatbool == true && goldbool == true)
                {
                    doorcanvas.enabled = false;
                    endcanvas.enabled = true;
                    if (Input.GetMouseButtonDown(0))
                    {
                        thankscanvas.SetActive(true);
                        goldbool = false;
                        hatbool = false;
                    }

                }
            }

            if (hit.transform.tag == "hat")
            {
                hatcanvas.enabled = true;

                if (Input.GetMouseButton(0))
                {
                    musicsource.PlayOneShot(pickupitem);
                    Destroy(hat);

                    hatbool = true;
                }

            }
            if (hatbool == true)
            {
                hatimage.SetActive(true);
            }
            else { hatimage.SetActive(false); }

            if (goldbool == true)
            {
                goldimage.SetActive(true);
            }
            else { goldimage.SetActive(false); }

            if (hit.transform.tag == "stand" && hatbool == true)
            {
                standcanvas.enabled = true;
            }

            if (hit.transform.tag == "standcanvas" && hatbool == true)
            {
                standcanvas.enabled = true;
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
        if (currentText != null)
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
