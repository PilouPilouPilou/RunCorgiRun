using UnityEngine;

public class Pill : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.PillSecondsOnScreen;
        base.Start();
    }
}
