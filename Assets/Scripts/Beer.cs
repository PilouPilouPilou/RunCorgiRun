
public class Beer : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.BeerSecondsOnScreen;
        base.Start();
    }
}
