using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreA5 : MonoBehaviour {


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
                    UIScript.Unlock4();
                    if (scoreAttemp == false && stopThatScoreC5.scoreAttemp == false && stopThatScoreI5.scoreAttemp == false && stopThatScoreS5.scoreAttemp == false && stopThatScoreSa5.scoreAttemp == false)
                    {
                        UIScript.Unlock9();
                    }

                    if (scoreAttemp == false && stopThatScoreC5.scoreAttemp == false && stopThatScoreI5.scoreAttemp == false && stopThatScoreS5.scoreAttemp == false && stopThatScoreSa5.scoreAttemp == false && stopThatScoreB3.scoreAttemp == false)
                    {
                        UIScript.Unlock10();
                    }
                }
            }

        } 

    }

}
