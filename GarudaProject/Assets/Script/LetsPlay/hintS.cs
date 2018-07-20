using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintS : MonoBehaviour
{

    // Use this for initialization
    static int hintCount = 3;
    public string soal;

    public RectTransform hintGui;
    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;


    void Start()
    {
	lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);

    }

    // Update is called once per frame
    void Update()
    {
    	hintGui.GetComponent<TMPro.TextMeshProUGUI>().text = hintCount.ToString();
    }

    private void OnMouseDown()
    {
        if (hintCount >= 3)
        {
        	lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            hintCount = hintCount - 1;
        }
        else if (hintCount >= 2)
        {
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            hintCount = hintCount - 1;
        }
        else if (hintCount >= 1)
        {
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            hintCount = hintCount - 1;
        }
    }
}
