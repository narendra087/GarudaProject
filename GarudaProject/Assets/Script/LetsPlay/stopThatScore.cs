using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopThatScore : MonoBehaviour {

    int scoreAttemp = 1;
    public static int nilaiGo = 0;

    public static List<int> savedNilai = new List<int>() { 0, 0, 0, 0, 0 };
    // Use this for initialization
    void Start () {
        Debug.Log(scoreS.nilai);

    }

    // Update is called once per frame
    void Update () {
		if (scoreAttemp > 1)
        {
            nilaiGo += 1;

            savedNilai[nilaiGo] = scoreS.nilai;

            Debug.Log(scoreS.nilai);
        }

	}
}
