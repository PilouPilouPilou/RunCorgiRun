using UnityEngine;

public class Moonshine : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.MoonshineSecondsOnScreen;
        base.Start();
    }
}
