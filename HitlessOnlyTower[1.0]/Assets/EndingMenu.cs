using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        Debug.Log ("Loading menu...");
    }

    public void QuitGame ()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}
