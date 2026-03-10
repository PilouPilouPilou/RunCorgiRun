using System.Collections;
using UnityEngine;

public class Poop : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.PoopSecondsOnScreen;
        base.Start();
    }
}
