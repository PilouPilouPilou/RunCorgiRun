
using DG.Tweening;

public class Beer : TimedObject
{
    public void Start()
    {
        SecondsOnScreen = GameParameters.BeerSecondsOnScreen;
        base.Start();
        
        transform.DOScale(1f + GameParameters.BeerPulseAmount, 1f / GameParameters.BeerPulseSpeed)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
