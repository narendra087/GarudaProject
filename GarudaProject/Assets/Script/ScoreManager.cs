using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    Dictionary<string, Dictionary<string, int>> playerScores;
    int changeCounter = 0;

    void Start()
    {
        //SetScore("Dummy A", "Rank", PlayerScoreList.urutan);
        SetScore("Dummy A", "ID Pegawai", 12345);
        //SetScore("Imam", "Divisi", 121212);
        SetScore("Dummy A", "Score", 100);

        //SetScore(gmScript.username, "Rank", PlayerScoreList.urutan);
        SetScore(gmScript.username, "ID Pegawai", gmScript.idPegawai);
        SetScore(gmScript.username, "Score", gmScript.SavedScore);

        //SetScore("Dummy B", "Rank", PlayerScoreList.urutan);
        SetScore("Dummy B", "Score", 101);

        //SetScore("Dummy C", "Rank", PlayerScoreList.urutan);
        SetScore("Dummy C", "Score", 102);

        //SetScore("Dummy D", "Rank", PlayerScoreList.urutan);
        SetScore("Dummy D", "Score", 1003);

        //SetScore("Dummy E", "Rank", PlayerScoreList.urutan);
        SetScore("Dummy E", "Score", 1004);
        SetScore("Dummy F", "Score", 1004);
        SetScore("Dummy G", "Score", 1004);
        SetScore("Dummy H", "Score", 1004);


    }

    public static void Testing()
    {
        Debug.Log("Masuk");
        Debug.Log(gmScript.SavedScore);
    }

    void Init()
    {
        if (playerScores != null)
            return;

        playerScores = new Dictionary<string, Dictionary<string, int>>();
    }

    public int GetScore(string username, string scoreType)
    {
        Init();

        if (playerScores.ContainsKey(username) == false)
        {
            return 0;
        }

        if (playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }

        return playerScores[username][scoreType];
    }

    public void SetScore(string username, string scoreType, int value)
    {
        Init();
        changeCounter++;
        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;
    }

    public void ChangeScore(string username, string scoreType, int amount)
    {
        Init();

        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }

    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();

        return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray();
    }

    public int GetChangeCounter()
    {
        return changeCounter;
    }

}
