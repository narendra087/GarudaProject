using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public static UIScript Instance { get; private set; }

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }

    [SerializeField]
    private Text pointsTxt;

    //public void SignIn()
    //{
      //  PlayGamesScript.SignIn();
    //}

    public void GetPoint()
    {
        ManagerScript.Instance.IncrementCounter();
    }

    public void Restart()
    {
        ManagerScript.Instance.RestartGame();
    }

    public static void Unlock1()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_synergy_master);
    }

    public static void Unlock2()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_integrity_master);
    }

    public static void Unlock3()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_customer_focus_master);
    }

    public static void Unlock4()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_agility_master);
    }

    public static void Unlock5()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_safety_master);
    }

    public static void Unlock6()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_silver_player);
    }

    public static void Unlock7()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_gold_player);
    }

    public static void Unlock8()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_platinum_player);
    }

    public static void Unlock9()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_master_of_sincerity);
    }

    public static void Unlock10()
    {
        PlayGamesScript.UnlockAchievement(GarudaGames.achievement_god_of_sincerity);
    }

    public void ShowAchievements()
    {
        PlayGamesScript.ShowAchievementsUI();
    }

    public void ShowLeaderboards()
    {
        PlayGamesScript.ShowLeaderboardsUI();
    }

    public void UpdatePointsText()
    {
        pointsTxt.text = ManagerScript.Counter.ToString();
    }


   }
