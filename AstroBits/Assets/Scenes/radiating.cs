using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.GetComponent<MeshRenderer>().material); 
      Debug.Log( gameObject.GetComponent<MeshRenderer>().material); 
      Debug.Log(gameObject.GetComponent<MeshRenderer>().material.mainTexture);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
