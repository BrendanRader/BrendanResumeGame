using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRG_Buttons : MonoBehaviour
{
    public void education()
    {
        SceneManager.LoadScene(2);
    }

    public void skills()
    {
        SceneManager.LoadScene(3);
    }

    public void software()
    {
        SceneManager.LoadScene(4);
    }

    public void hobbies()
    {
        SceneManager.LoadScene(5);
    }

    public void contact()
    {
        SceneManager.LoadScene(6);
    }

    public void organizations()
    {
        SceneManager.LoadScene(7);
    }

    public void achievements()
    {
        SceneManager.LoadScene(8);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void back()
    {
        SceneManager.LoadScene(1);
    }
}
