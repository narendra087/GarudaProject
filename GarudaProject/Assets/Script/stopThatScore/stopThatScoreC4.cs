using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreC4 : MonoBehaviour {


    private static bool scoreAttemp = true;

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
                }
            }

        } 

    }

}
