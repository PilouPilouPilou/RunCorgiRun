using UnityEngine;

public class Bone : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.BoneSecondsOnScreen;
        base.Start();
    }

}
