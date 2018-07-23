using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreA4 : MonoBehaviour {

    public Transform scoreCoba;

    private static bool scoreAttemp = true;

    void Start () {

        FindObjectOfType<scoreS>().start();

        scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();


    }

    // Update is called once per frame
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
