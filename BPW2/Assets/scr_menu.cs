using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_menu : MonoBehaviour {

    // Use this for initialization
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Homescene");
    }

    public void QuitGame()
    {
        Application.Quit();
       
    }
}
