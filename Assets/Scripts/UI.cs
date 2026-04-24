using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timeText;
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    public GameTimer GameTimer;
    
    public void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
    
    public void ResetScore()
    {
        scoreText.text = "Score: 0";
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }
    
    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
    }

    public void HideGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
    }

    public void ShowTime()
    {
        timeText.text = GameTimer.GetTimeAsString();
    }
    
    public void ShowGameOverScreen()
    {
        CanvasGroupDisplayer.Show(GameOverScreenCanvasGroup);
    }
}
