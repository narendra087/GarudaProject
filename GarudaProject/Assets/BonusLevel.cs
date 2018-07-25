using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusLevel : MonoBehaviour {

	// Use this for initialization
	//public GameObject[] unlockBonus;
	int nilaiB;
    public RectTransform Text;
    public RectTransform hidup1;
    public RectTransform hidup2;
    public RectTransform hidup3;

    void Start () {
		nilaiB = scoreS.nilai;
       // result.text = scoreS.nilai;
        Text.GetComponent<TMPro.TextMeshProUGUI>().text = scoreS.nilai.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (scoreS.nilai >= 1111)
		{
			hidup1.gameObject.SetActive(false);
			//unlockBonus[0].SetActive(false);
		} else if (scoreS.nilai >= 2222)
		{
			hidup1.gameObject.SetActive(false);
			hidup2.gameObject.SetActive(false);
			// unlockBonus[0].SetActive(false);
			// unlockBonus[1].SetActive(false);
		} else if (scoreS.nilai >= 3333)
		{
			hidup1.gameObject.SetActive(false);
			hidup2.gameObject.SetActive(false);
			hidup3.gameObject.SetActive(false);
			// unlockBonus[0].SetActive(false);
			// unlockBonus[1].SetActive(false);
			// unlockBonus[2].SetActive(false);
		}
	}
}
