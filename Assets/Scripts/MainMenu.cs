using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Donate()
    {
        SceneManager.LoadScene(3);
    }

    public void BP()
    {
        SceneManager.LoadScene(2);
    }
}
