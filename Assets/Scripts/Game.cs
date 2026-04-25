using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    public GameTimer GameTimer;
    public Corgi Corgi;
    public BeerPlacer BeerPlacer;
    public BonePlacer BonePlacer;
    public MoonshinePlacer MoonshinePlacer;
    public PillPlacer  PillPlacer;
    public Music Music;
    
    private bool isGameRunning = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ui.HideGameOverScreen();
        Ui.ShowStartScreen();
        Music.PlayMenuMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {
            Ui.ShowTime();
        }
    }

    public void OnStartButtonClicked()
    {
        Ui.HideStartScreen();
        InitializeGame();
    }
    
    public void OnPlayAgainButtonClicked()
    {
        Ui.HideGameOverScreen();
        InitializeGame();
    }

    private void InitializeGame()
    {
        isGameRunning = true;
        GameTimer.StartTimer(durationInSeconds:10, OnTimerFinished);
        StartPlacers();
        ScoreKeeper.ResetScore();
        Ui.ResetScore();
        Corgi.Reset();
        Music.PlayGameMusic();
    }

    private void StartPlacers()
    {
        BeerPlacer.StartPlacing();
        PillPlacer.StartPlacing();
        MoonshinePlacer.StartPlacing();
        BonePlacer.StartPlacing();
    }

    private void StopPlacers()
    {
        BeerPlacer.StopPlacing();
        PillPlacer.StopPlacing();
        MoonshinePlacer.StopPlacing();
        BonePlacer.StopPlacing();
    }
    
    public void OnTimerFinished()
    {
        Ui.ShowGameOverScreen();
        isGameRunning = false;
        StopPlacers();
        Music.PlayMenuMusic();
    }

    public bool isPlaying()
    {
        return isGameRunning;
    }
}
