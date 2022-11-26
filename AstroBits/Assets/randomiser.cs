using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomiser : MonoBehaviour
{

    public float[] poslist = new float[]{-1.22f,-0.31f,0.8f,1.76f,3.41f,5f,7.62f,8.8f};

    void shuffle(){
        Debug.Log("before");
        Debug.Log(poslist);
        for(int n=0;n<30;n++)
      {  int i = (int)Mathf.Floor( Random.Range(0,7));
      Debug.Log(i);
        float temp = poslist[i];
        poslist[i]=poslist[i+1];
        poslist[i+1] = temp;}

        Debug.Log("after");
        Debug.Log(poslist);
    }

    // Start is called before the first frame update
    void Start()
    {
        shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
