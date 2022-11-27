using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("inside loadgame");
    // SceneManager.LoadScene(3);

    }


 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        SceneManager.LoadScene(2);
        if(Input.GetMouseButton(1))
        Application.Quit();
    }
}
