using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text GoalsText;
    [SerializeField] private Text ScoreText;

    private int goalsScored = 0;
    private float score = 0;

    public void IncreaseGoalCount()
    {
        goalsScored++;
        UpdateUI();
    }
    public void IncreaseScore(float amount)
    {
        score += amount;
        UpdateUI();
    }
    void UpdateUI()
    {
        GoalsText.text = goalsScored.ToString();
        ScoreText.text = score.ToString();
    }
}

