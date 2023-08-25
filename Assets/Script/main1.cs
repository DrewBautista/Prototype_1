using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main1 : MonoBehaviour
{
    // buttons
    public void engineering()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ncb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void cihm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void ulane()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void library()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void ocampo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    // dropdown
    public void x(int z)
    {
        if (z == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
        }
        if (z == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
        }
        if (z == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
        }
    }
    //EXITS BUTTON
    public void exit()
    {
        Application.Quit();
    }
    

}
