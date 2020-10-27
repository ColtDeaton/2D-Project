using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour

{
    private int LoadLevel;

    // Start is called before the first frame update
    private void Start()
    {

        LoadLevel = SceneManager.GetActiveScene().buildIndex + 1;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(LoadLevel);
    }


}
