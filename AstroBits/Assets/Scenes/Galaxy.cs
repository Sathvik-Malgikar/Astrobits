using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy
{
    public Galaxy()
    {
        SolarSystems = new List<Orbital>();
    }  

    public List<Orbital> SolarSystems;

    public void Generate(int numStars)
    {
        Orbital ss = new Orbital();
        SolarSystems.Add(ss); 
        //Making a solar system with a single star
        
    }

    public void LoadFromFile(string fileName)
    {

    }
}
