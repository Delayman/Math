using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{

    public void Begin()
    {
        SceneManager.LoadScene("Main");

    }
    public void Quit()
    {
        Debug.Log("Quit");

        Application.Quit();

    }
}
