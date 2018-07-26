using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreSa5 : MonoBehaviour {


    public static bool scoreAttemp = true;

    void Start () {

        FindObjectOfType<scoreS>().start();

    }

    public void Update () {

            if (scoreAttemp == true)
            {
            if (Timer.timeLeft >= 0)
            {
                GetComponent<scoreS>().ScoreOn();
                if (scoreS.sudah == true)
                {
                    scoreAttemp = false;
                    UIScript.Unlock5();
                    if (scoreAttemp == false && stopThatScoreA5.scoreAttemp == false && stopThatScoreI5.scoreAttemp == false && stopThatScoreS5.scoreAttemp == false && stopThatScoreC5.scoreAttemp == false)
                    {
                        UIScript.Unlock9();
                    }

                    if (scoreAttemp == false && stopThatScoreA5.scoreAttemp == false && stopThatScoreI5.scoreAttemp == false && stopThatScoreS5.scoreAttemp == false && stopThatScoreC5.scoreAttemp == false && stopThatScoreB3.scoreAttemp == false)
                    {
                        UIScript.Unlock10();
                    }
                }
            }

        } 

    }

}
