using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_raycast : MonoBehaviour
{

    public float rayDistance;
    [SerializeField]
    public Behaviour haloplant;
    public Behaviour groundpillow;
    public Behaviour bedpillow1;
    public Behaviour bedpillow2;
    public Behaviour dresserknob;
    public Behaviour dresserbook;
    public Behaviour groundbook;
    public Behaviour standlamp1;
    public Behaviour standlamp2;
    public Behaviour posters;
    public Behaviour closetdoor1;
    public Behaviour closetdoor2;
    public Behaviour bedpainting;
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
            hit.transform.SendMessage("HitByRay");
            haloplant.enabled = false;
            groundpillow.enabled = false;
            bedpillow1.enabled = false;
            bedpillow2.enabled = false;
            dresserknob.enabled = false;
            dresserbook.enabled = false;
            groundbook.enabled = false;
            standlamp1.enabled = false;
            standlamp2.enabled = false;
            posters.enabled = false;
            closetdoor1.enabled = false;
            closetdoor2.enabled = false;
            bedpainting.enabled = false;




            if (hit.transform.tag == "a")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                    haloplant.enabled = true;
            }

            if (hit.transform.tag == "groundpillow")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                groundpillow.enabled = true;
            }

            if (hit.transform.tag == "bedpillow1")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                bedpillow1.enabled = true;
            }

            if (hit.transform.tag == "bedpillow2")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                bedpillow2.enabled = true;
            }

            if (hit.transform.tag == "dresserknob")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    
                    dresseropen.SetActive(true);
                    dresserclosed.SetActive(false);
                    keybool = true;
                }
                dresserknob.enabled = true;
            }

            if (hit.transform.tag == "dresserbook")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                dresserbook.enabled = true;
            }
            if (hit.transform.tag == "groundbook")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                groundbook.enabled = true;
            }
            if (hit.transform.tag == "standlamp1")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                standlamp1.enabled = true;
            }
            if (hit.transform.tag == "standlamp2")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                standlamp2.enabled = true;
            }
            if (hit.transform.tag == "posters")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                posters.enabled = true;
            }
            if (hit.transform.tag == "closetdoor1")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if(keybool == true)
                    {
                        closetclosed.SetActive(false);
                        closetopen.SetActive(true);
                    }
                    canvas.SetActive(true);
                }
                closetdoor1.enabled = true;
            }
            if (hit.transform.tag == "closetdoor2")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (keybool == true)
                    {
                        Destroy(closetclosed);
                        closetopen.SetActive(true);
                    }
                    canvas.SetActive(true);
                }
                closetdoor2.enabled = true;
            }
            if (hit.transform.tag == "bedpainting")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(true);
                }
                bedpainting.enabled = true;
            }
           
        }
    }
}

