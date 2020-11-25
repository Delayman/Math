using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearBack : MonoBehaviour
{
    public void Clear()
    {
        SceneManager.LoadScene("Main");

    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");

    }
}
