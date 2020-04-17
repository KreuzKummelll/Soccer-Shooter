using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text GoalsText;
    private int goalsScored = 0;

    public void IncreaseScore()
    {
        goalsScored++;
        UpdateUI();
    }
    void UpdateUI()
    {
        GoalsText.text = goalsScored.ToString();
    }
}

