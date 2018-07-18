using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint5 : MonoBehaviour
{

    // Use this for initialization
    public static int hintCount;
    public string soal = "trust";

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public RectTransform lett5;
    public static List<string> lett = new List<string>() { "lett1", "lett2", "lett3", "lett4", "lett5" };


    void Start()
    {
        hintCount = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (hintCount >= 5)
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            hintCount -= 1;
        }
        else if (hintCount >= 4)
        {
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            hintCount -= 1;
        }
        else if (hintCount >= 3)
        {
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            hintCount -= 1;
        } else if (hintCount >= 2)
        {
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            hintCount -= 1;
        }
        else if (hintCount >= 1)
        {
            lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            hintCount -= 1;
        }
    }
}
