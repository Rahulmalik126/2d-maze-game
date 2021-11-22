using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonmanager : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("0");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("1");
    }
 
}