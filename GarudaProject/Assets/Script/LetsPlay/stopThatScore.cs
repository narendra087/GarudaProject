using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScore : MonoBehaviour {

    public Transform scoreCoba;

    static int scoreAttemp = 1;
   
    // public static int nilaiGo = 0;

    // public static List<int> savedNilai = new List<int>() { 0, 0, 0, 0, 0 };
    // Use this for initialization
    void Start () {

        Debug.Log(scoreS.nilai);
        FindObjectOfType<scoreS>().start();
        if (scoreAttemp == 1)
        {
          //FindObjectOfType<scoreS>().update();
        }


        scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();


    }

    // Update is called once per frame
    void Update () {
		if (scoreAttemp == 1)
        {
            //FindObjectOfType<scoreS>().update();
            // nilaiGo += 1;
            scoreCoba.GetComponent<TMPro.TextMeshProUGUI>().text = scoreAttemp.ToString();
            scoreAttemp = 0;
            //savedNilai[nilaiGo] = scoreS.nilai;

            Debug.Log(scoreS.nilai);
        }

	}
}
