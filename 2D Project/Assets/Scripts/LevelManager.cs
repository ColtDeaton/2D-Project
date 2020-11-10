using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    Vector2 playerInitPosition;

    void Start()
    {
        playerInitPosition = FindObjectOfType<Life>().transform.position;
    }

    public void Restart()
    {
        //saves player's position at start of map will respawn player
        FindObjectOfType<Life>().transform.position = playerInitPosition;
    }
}
