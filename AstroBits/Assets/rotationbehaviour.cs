using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationbehaviour : MonoBehaviour
{
   
        public bool active;
        public float speed;
    // Start is called before the first frame update
    void Start()
    {
      active=false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("p")){
            active=!active;
        }


          if(active)
        gameObject.GetComponent<Transform>().Rotate(Vector3.down,speed);
    }
}
