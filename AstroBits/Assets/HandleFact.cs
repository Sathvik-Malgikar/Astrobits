using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleFact : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
timer=0f;


        gameObject.GetComponent<TextMeshProUGUI>().text = "";
    }

    public void changeText(string s){
gameObject.GetComponent<TextMeshProUGUI>().text = s;
    }

    // Update is called once per frame
    void Update()
    {

          if(timer!=0f){
            timer-=Time.deltaTime;
            if(timer<=0){
            timer=0f;
               gameObject.GetComponent<TextMeshProUGUI>().text = "";
            }
          }

        else if(gameObject.GetComponent<TextMeshProUGUI>().text!="" && timer==0f){
timer = 2f;
        }

    }

}
