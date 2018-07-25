using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScoreB3 : MonoBehaviour {


    private static bool scoreAttemp = true;
  
    public void Start () {

        FindObjectOfType<scoreS>().start();

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
