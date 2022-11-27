using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class updatedistance : MonoBehaviour
{
    public float dist;
    private GameObject origin;
    private GameObject mespoint;
    // Start is called before the first frame update
    void Start()
    {
        origin = GameObject.Find("origin");
        mespoint = GameObject.Find("measuringpoint");
      
    }

    // Update is called once per frame
    void Update()
    {
            dist = (origin.transform.position - mespoint.transform.position).magnitude;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Distance from Earth in nanolightyears :"+dist;
    }
}
