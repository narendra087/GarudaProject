using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreA3 : MonoBehaviour {

    public Transform scoreCoba;

    private static bool scoreAttemp = true;

    void Start () {


    }

    public void Update () {

            if (scoreAttemp == true)
            {

            GetComponent<scoreS>().ScoreOn();
            if (scoreS.sudah == true)
            {
                scoreAttemp = false;
            }


        } 
    }

}
