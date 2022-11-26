using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationbehaviour : MonoBehaviour
{
   
        public bool active;
    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
          if(active)
        GameObject.Find("planets").GetComponent<Transform>().Rotate(Vector3.down,1f);
    }
}
