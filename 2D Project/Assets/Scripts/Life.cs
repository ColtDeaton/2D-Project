using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public GameObject[] lives;
    private int livesleft;
    private bool dead;


    private void Start()
    {
        livesleft = lives.Length;
    }

    void Update()
    {
       if (dead == true)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "damage")
        {
            FindObjectOfType<LevelManager>().Restart();
            if (livesleft >= 1)
            {
                livesleft--;
                Destroy(lives[livesleft].gameObject);
                if (livesleft < 1)
                {
                    dead = true;
                }
            }
            
        }
    }
}
