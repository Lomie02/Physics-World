using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : GameManager
{
    [Header("Regular")]
    [SerializeField] Text m_ScoreText;
    [SerializeField] Text m_CoinsText;

    [Header("Results Texts")]
    [SerializeField] Text m_ScoreTextEnd;
    [SerializeField] Text m_CoinsGrabbedEnd;
    [SerializeField] Text m_HighScoreText;

    int m_ScoreCount;
    int m_CoinsCount;

    int m_TotalCoins;

    SaveManager m_Data;

    private void Start()
    {
        m_Data = FindObjectOfType<SaveManager>();
    }
    public void AddScore(int _amount)
    {
        m_ScoreCount += _amount;
        UpdateUi();
    }

    public void RemoveScore(int _amount)
    {
        m_ScoreCount -= _amount;

        if (m_ScoreCount < 0)
        {
            m_ScoreCount = 0;
        }
        UpdateUi();
    }

    public void AddCoins(int _amount)
    {
        m_CoinsCount += _amount;
        UpdateUi();
    }

    void UpdateUi()
    {
        m_ScoreText.text = "Score: " + m_ScoreCount.ToString();
        m_CoinsText.text = "Coins: $" + m_CoinsCount.ToString();
    }

    public void CompleteResults()
    {
        m_Highscore = m_Data.GetHighScore();

        m_TotalCoins += m_CoinsCount;
        UpdateResults();
    }

    void UpdateResults()
    {
        m_ScoreTextEnd.text = m_ScoreCount.ToString();
        m_CoinsGrabbedEnd.text = m_CoinsCount.ToString();
        m_CoinsTotalEnd.text = m_TotalCoins.ToString();

        m_Data.SetPlayersCoins(m_TotalCoins);
    }
}