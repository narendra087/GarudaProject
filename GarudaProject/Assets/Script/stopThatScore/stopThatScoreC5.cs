using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreC5 : MonoBehaviour {


    private static bool scoreAttemp = true;

    void Start () {

        FindObjectOfType<scoreS>().start();

    }

    public void Update () {

            if (scoreAttemp == true)
            {
            if (Timer.timeLeft >= -1)
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
