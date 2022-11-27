using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        Debug.Log("quit");
    Application.Quit(0);


    }


 

    // Update is called once per frame
    void Update()
    {
        
    }
}
