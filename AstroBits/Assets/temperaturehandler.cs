using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class temperaturehandler : MonoBehaviour
{
    public float temp;
    private GameObject sun;
    private GameObject mespoint;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("sunpoint");
        mespoint = GameObject.Find("measuringpoint");
      
    }

    // Update is called once per frame
    void Update()
    {
            temp = (sun.transform.position - mespoint.transform.position).magnitude;
            temp/=20;
            temp = 273- temp;
        gameObject.GetComponent<TextMeshProUGUI>().text = "temperature in kelvin :"+temp;
    }
}
