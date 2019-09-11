using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }
    public void loadChronic()
    {
        SceneManager.LoadScene(1);
    }
    public void loadAcute()
    {
        SceneManager.LoadScene(2);
    }
    public void loadEnvironments()
    {
        SceneManager.LoadScene(3);
    }
    public void zombiVR()
    {
        SceneManager.LoadScene(4);
    }
    public void forest()
    {
        SceneManager.LoadScene(5);
    }
    public void sunset()
    {
        SceneManager.LoadScene(6);
    }
    public void moonVR()
    {
        SceneManager.LoadScene(7);
    }
    public void video()
    {
        SceneManager.LoadScene(8);
    }
}
