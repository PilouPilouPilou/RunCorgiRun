using UnityEngine;

public class NewMonoBehaviourScript : TimedObjectPlacer
{
    public void Start()
    {
        minimumSecondsToWait = GameParameters.PillMinimumSecondsToWait;
        maximumSecondsToWait = GameParameters.PillMaximumSecondsToWait;
    }
}
