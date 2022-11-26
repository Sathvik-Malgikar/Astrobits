using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomiser : MonoBehaviour
{

    
    public bool active;
    public Vector3[] poslist;

    void shuffle(Vector3[] arr){

        // Debug.Log(poslist[0]);

        // Debug.Log("before");
        // for(int j =0 ; j < 8 ; j++)
        // Debug.Log(arr[j]);
        for(int n=0;n<150;n++)
      {  int i = (int)Mathf.Floor( Random.Range(0,7));
    //   Debug.Log(i);
        Vector3 temp = arr[i];
        arr[i]=arr[i+1];
        arr[i+1] = temp;}

        Debug.Log("after");
           for(int j =0 ; j < 8 ; j++)
        Debug.Log(arr[j]);
    }

    void assign(Vector3[] arr){

        Debug.Log(GameObject.Find("mercury").GetComponent<Transform>().position);


          GameObject.Find("mercury").GetComponent<Transform>().position = arr[0];
          GameObject.Find("venus").GetComponent<Transform>().position = arr[1];
          GameObject.Find("earth").GetComponent<Transform>().position = arr[2];
          GameObject.Find("mars").GetComponent<Transform>().position = arr[3];
          GameObject.Find("jupiter").GetComponent<Transform>().position = arr[4];
          GameObject.Find("saturn").GetComponent<Transform>().position = arr[5];
          GameObject.Find("uranus").GetComponent<Transform>().position = arr[6];
          GameObject.Find("neptune").GetComponent<Transform>().position = arr[7];
    }

    // Start is called before the first frame update
    void Start()
    {
        poslist = new Vector3[8];

           poslist[0] = GameObject.Find("mercury").GetComponent<Transform>().position;
          poslist[1] = GameObject.Find("venus").GetComponent<Transform>().position;
          poslist[2] = GameObject.Find("earth").GetComponent<Transform>().position;
          poslist[3] = GameObject.Find("mars").GetComponent<Transform>().position;
          poslist[4] = GameObject.Find("jupiter").GetComponent<Transform>().position;
          poslist[5] = GameObject.Find("saturn").GetComponent<Transform>().position;
          poslist[6] = GameObject.Find("uranus").GetComponent<Transform>().position;;
          poslist[7] = GameObject.Find("neptune").GetComponent<Transform>().position;
    
        shuffle(poslist);
        assign(poslist);
//    Debug.Log( poslist[7] );
    }

    // Update is called once per frame
    void Update()
    {
        // if(active)
        // GameObject.Find("")
    }
}
