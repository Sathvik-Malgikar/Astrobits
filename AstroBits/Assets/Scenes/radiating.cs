using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiating : MonoBehaviour
{
    public bool increasing=true;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (increasing ){

        gameObject.GetComponent<Light>().intensity+=2f*Time.deltaTime;
        if(gameObject.GetComponent<Light>().intensity>=1.5)
        increasing=false;
        }else{
            gameObject.GetComponent<Light>().intensity-=2f*Time.deltaTime;
        if(gameObject.GetComponent<Light>().intensity<=0)
        increasing=true;
        }
      
        
    }
}
