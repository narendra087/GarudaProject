
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class scoreS : MonoBehaviour {

    public Transform score;
    //public Transform scoreCoba;
    public Transform SkorTersimpan;

    public static int nilai = 0;
    public static int SavedScore;
    public string soal;

    public static bool sudah;

    static int scoreAttemp = 1;

    // public static int nilaiLaju = 0;

    //  public static List<int> savedNilai = new List<int>() { 0, 0, 0, 0, 0 };

    // Use this for initialization
    public void start () {
        sudah = false;
        LoadScore();
        SkorTersimpan.GetComponent<TMPro.TextMeshProUGUI>().text = SavedScore.ToString();
        score.GetComponent<TMPro.TextMeshProUGUI>().text = nilai.ToString();
       // scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();

    }

    // Update is called once per frame
    public void ScoreOn () {
        Debug.Log("Masuk Update");
        if (popUp4.game == 1 || popUp5.game == 1 || popUp6.game == 1 || popUp7.game == 1 || popUp8.game == 1 || popUp9.game == 1 || popUp10.game == 1 || popUp11.game == 1 || popUp14.game == 1)
        {
            //Debug.Log("test1");
            if (gm4.currentWord == soal && gm4.count == soal.Length || gm5.currentWord == soal && gm5.count == soal.Length || gm6.currentWord == soal && gm6.count == soal.Length || gm7.currentWord == soal && gm7.count == soal.Length ||
                gm8.currentWord == soal && gm8.count == soal.Length || gm9.currentWord == soal && gm9.count == soal.Length || gm10.currentWord == soal && gm10.count == soal.Length || gm11.currentWord == soal && gm11.count == soal.Length || gm14.currentWord == soal && gm14.count == soal.Length)
                {

                    //Debug.Log("test2");
                    nilai = nilai + 100 + Timer.timeLeft * 2;
                Social.ReportScore(12345, "CgkIt5G-0sQdEAIQAQ", (bool success) => {
                    // handle success or failure
                });

                //nilaiLaju += 1;
                //savedNilai[nilaiLaju] = nilai;

                // scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();
                //  scoreAttemp = 0;

                score.GetComponent<TMPro.TextMeshProUGUI>().text = nilai.ToString();
                //stopThatScore.scoreAttemp = false;
               // stopThatScore.scoreAttempChange = true;
                sudah = true;

                }
                if (Timer.timeLeft <= 0)
            {
                nilai = nilai - 3;

                //if (stopThatScoreB3.Start = true)
                //{
                //    nilai = nilai - 1000;
                //}
            }
            //nilai = nilai - 3;



        }
        //nilai = nilai - 1;
        //nilai = nilai + 100 + Timer.timeLeft * 2;
       // nilai = nilai - 3;


    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", nilai);
    }

    public void LoadScore()
    {
        SavedScore = PlayerPrefs.GetInt("Score", 0);
    }

    public void DeleteScore()
    {
        PlayerPrefs.DeleteKey("Score");
    }

    public void ScoreOff()
    {
        Debug.Log("");
    }
}
