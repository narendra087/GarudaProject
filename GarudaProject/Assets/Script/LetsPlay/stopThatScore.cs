using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    int scoreAttemp = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreS.nilai > 0)
        {
            scoreS.nilai = 0;
        }

	}
}
