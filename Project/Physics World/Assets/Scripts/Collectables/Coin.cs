using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int m_CoinWorth = 1;
    [SerializeField] int m_ScoreAmount = 25;
    public int GetCoinWorth()
    {
        return m_CoinWorth;
    }

    public int GetScoreWorth()
    {
        return m_ScoreAmount;
    }

    public void CoinGrabbed()
    {
        Destroy(gameObject);
    }
}
