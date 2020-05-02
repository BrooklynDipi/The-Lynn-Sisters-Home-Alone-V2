using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void TrailerPark()
    {
        SceneManager.LoadScene("TrailerPark");
    }

    public static void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
