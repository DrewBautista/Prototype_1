using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main2 : MonoBehaviour
{
    // buttons
    public void engineering()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
    public void ncb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }
    public void cihm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
    public void ulane()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }
    public void library()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }
    public void ocampo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }
    //Back Button
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
