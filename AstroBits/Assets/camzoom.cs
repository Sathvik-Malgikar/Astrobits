using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camzoom : MonoBehaviour
{
    public float zoomlevel = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zoomlevel<=48)
        zoomlevel+=Time.deltaTime;
        else
        zoomlevel=48f;
    }
}
