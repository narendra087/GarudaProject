using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusLevel : MonoBehaviour {

	// Use this for initialization
	public GameObject[] unlockBonus;
	int nilaiB;

	void Start () {
		nilaiB = scoreS.nilai;
		// Text.text = scoreS.nilai;
	}
	
	// Update is called once per frame
	void Update () {
		if (nilaiB == 1111)
		{
			unlockBonus[1].SetActive(false);
		} else if (nilaiB == 2222)
		{
			unlockBonus[1].SetActive(false);
			unlockBonus[2].SetActive(false);
		} else if (nilaiB == 3333)
		{
			unlockBonus[1].SetActive(false);
			unlockBonus[2].SetActive(false);
			unlockBonus[3].SetActive(false);
		}
	}
}
