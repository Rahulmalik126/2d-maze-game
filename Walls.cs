using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject GOPanel;

    // Start is called before the first frame update
    void Start()
    {
        GOPanel.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            GOPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
