using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

public class BonusLevel : MonoBehaviour {

	// Use this for initialization
	public GameObject[] unlockBonus;
	int nilaiB;
    public RectTransform Text;

    void Start () {
		nilaiB = scoreS.nilai;
       // result.text = scoreS.nilai;
         Text.GetComponent<TMPro.TextMeshProUGUI>().text = scoreS.nilai.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (scoreS.nilai == 1111)
		{
			unlockBonus[1].SetActive(false);
		} else if (scoreS.nilai == 2222)
		{
			unlockBonus[1].SetActive(false);
			unlockBonus[2].SetActive(false);
		} else if (scoreS.nilai == 3333)
		{
			unlockBonus[1].SetActive(false);
			unlockBonus[2].SetActive(false);
			unlockBonus[3].SetActive(false);
		}
	}
}
