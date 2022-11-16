using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : GameManager
{
    public void SetPlayersCoins(int _amount)
    {
        PlayerPrefs.SetInt("player_coins", _amount);
    }

    public int GetPlayersCoins()
    {
        return PlayerPrefs.GetInt("player_coins");
    }

    //==============================================

    public void SetHighScore(int _amount)
    {
        PlayerPrefs.SetInt("highscore_player", _amount);
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("highscore_player");
    }

    //==============================================
}