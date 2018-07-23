using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreA5 : MonoBehaviour {


    private static bool scoreAttemp = true;

    void Start () {

        FindObjectOfType<scoreS>().start();

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
