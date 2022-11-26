using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbital 
{
    public Orbital()
    {
        TimetoOrbit = 1;
    }
    public Orbital Parent;
    public List<Orbital> Children;
    public double Angle;

    public UInt64 OrbitalDistance;
    public UInt64 TimetoOrbit;
    public int GraphicId;

    // We need to be able to get X,Y and maybe Z coordinates for the purpose
    // of rendering the Orbital on screen
    public Vector3 Position
    {
        get
        {
            // Convert our orbit info into a vector that we can use to
            // render something as a Unity Game Object
            return new Vector3(
                (float)Math.Sin(Angle) * OrbitalDistance,
                (float)Math.Cos(Angle) * OrbitalDistance,
                0
            );
        }
    }

    public void Update(UInt64 TimesinceStart)
    {
        //Advance our angle by the correct amount of time
        float numOrbits=TimesinceStart/TimetoOrbit;
        Angle = numOrbits * 2*Math.PI;
    }

    public void Earth()
    {
        Angle = 0;
        OrbitalDistance = 150000000000;   //150 million km
        TimetoOrbit = 365*24*60*60;
    }
}
