using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreA4 : MonoBehaviour {

    public Transform scoreCoba;

    private static bool scoreAttemp = true;
   // public static bool scoreAttempChange;
   
    // public static int nilaiGo = 0;

    // public static List<int> savedNilai = new List<int>() { 0, 0, 0, 0, 0 };
    // Use this for initialization
    void Start () {

        FindObjectOfType<scoreS>().start();
        //startScore();

        //if (scoreAttemp == 1)
        //{
        //  FindObjectOfType<scoreS>().ScoreOn();
        // scoreAttemp = scoreAttemp - 1;
        //}
        scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();


    }

    // Update is called once per frame
    public void Update () {
       // for (scoreAttemp = 1; scoreAttemp >= 1; scoreAttemp--)
        //{
            if (scoreAttemp == true)
            {
                //FindObjectOfType<scoreS>().ScoreOn();
                //scoreAttemp = scoreAttemp - 1;
                //     Debug.Log("2");
               // FindObjectOfType<scoreS>().ScoreOn();
            GetComponent<scoreS>().ScoreOn();
            if (scoreS.sudah == true)
            {
                scoreAttemp = false;
            }
            //if(scoreAttempChange == true)
            //{
            //    scoreAttemp = false;
            //}

        } //else
          //{
          //    FindObjectOfType<scoreS>().ScoreOff();
          //}


        //if (scoreAttemp == 1)
        //{
        // Debug.Log("3");
        // scoreAttemp = scoreAttemp - 1;

        //FindObjectOfType<scoreS>().update();
        // nilaiGo += 1;
        scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();
       // kurang();
        //savedNilai[nilaiGo] = scoreS.nilai;

        //Debug.Log(scoreS.nilai);
    }

}
