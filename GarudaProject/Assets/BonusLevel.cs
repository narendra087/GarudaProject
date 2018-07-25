using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusLevel : MonoBehaviour {

	int nilaiB;
    public RectTransform Text;
    public RectTransform hidup1;
    public RectTransform hidup2;
    public RectTransform hidup3;

    void Start () {
		nilaiB = scoreS.nilai;
    }
	
	void Update () {
		if (scoreS.nilai >= 1111)
		{
			hidup1.gameObject.SetActive(false);
		}

		if (scoreS.nilai >= 2222)
		{
			hidup2.gameObject.SetActive(false);
		}

		if (scoreS.nilai >= 3333)
		{
			hidup3.gameObject.SetActive(false);
		}
	}
}
