using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : GameManager
{
    [SerializeField] Text m_ScoreText;
    [SerializeField] Text m_CoinsText;

    int m_ScoreCount;
    int m_CoinsCount;
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
}
