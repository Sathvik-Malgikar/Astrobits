using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabledummy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
         //gameObject.GetComponent<MeshRender>().enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.GetComponent<MeshRenderer>().enabled=true;
    gameObject.GetComponent<MeshCollider>().enabled=true;
    //gameObject.GetComponent("TeleportationAnchor").enabled=true;
    }
}
