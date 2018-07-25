﻿using UnityEngine;
 
public class ManagerScript : MonoBehaviour
{

    public static ManagerScript Instance { get; private set; }
    public static int Counter { get; private set; }

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }

    public void IncrementCounter()
    {
        Counter++;
        UIScript.Instance.UpdatePointsText();
    }

    public void RestartGame()
    {
        PlayGamesScript.AddScoreToLeaderboard(GarudaAchievement.leaderboard_leader, Counter);
        Counter = 0;
        UIScript.Instance.UpdatePointsText();
    }

}