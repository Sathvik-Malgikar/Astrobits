using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void loadGame(){


    SceneManager.LoadScene(3);


    }
    public void exitGame(){


    Application.Quit(0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
