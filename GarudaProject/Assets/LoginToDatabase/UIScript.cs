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

    public void SignIn()
    {
        PlayGamesScript.SignIn();
    }

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
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_synergy_master);
    }

    public void Unlock2()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_integrity_master);
    }

    public void Unlock3()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_customer_focus_master);
    }

    public static void Unlock4()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_agility_master);
    }

    public void Unlock5()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_safety_master);
    }

    public void Unlock6()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_silver_player);
    }

    public void Unlock7()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_gold_player);
    }

    public void Unlock8()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_platinum_player);
    }

    public void Unlock9()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_master_of_sincerity);
    }

    public void Unlock10()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_god_of_sincerity);
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