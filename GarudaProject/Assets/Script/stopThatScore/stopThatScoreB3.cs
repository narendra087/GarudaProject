using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreB3 : MonoBehaviour {


    public static bool scoreAttemp = true;
  
    public void Start () {

        FindObjectOfType<scoreS>().start();


    }

    // Update is called once per frame
    public void Update () {
        GetComponent<scoreS>().ScoreOn();
        if (scoreAttemp == true)
            {
            if (Timer.timeLeft >= 0)
            {
                GetComponent<scoreS>().ScoreOn();
                if (scoreS.sudah == true)
                {
                    scoreAttemp = false;
                    if (scoreAttemp == false && stopThatScoreA5.scoreAttemp == false && stopThatScoreI5.scoreAttemp == false && stopThatScoreS5.scoreAttemp == false && stopThatScoreC5.scoreAttemp == false && stopThatScoreSa5.scoreAttemp == false)
                    {
                        UIScript.Unlock10();
                    }
                }

            }
        } 

    }

}
