using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
if(Input.GetMouseButton(0))
   gameObject.transform.position =Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){

          gameObject.transform.position =Input.mousePosition;
          Debug.Log(gameObject.transform.position);
        }
    }
}
