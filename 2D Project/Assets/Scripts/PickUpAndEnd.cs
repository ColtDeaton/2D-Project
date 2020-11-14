using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PickUpAndEnd : MonoBehaviour
{
    public Text countCol;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        countCol.text = "Collected: " + count.ToString() + "/3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "collectable")
        {
            count += 1;
            Destroy(other.gameObject);
            countCol.text = "Collected: " + count.ToString() + "/3";
        }else if(other.tag == "end")
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
