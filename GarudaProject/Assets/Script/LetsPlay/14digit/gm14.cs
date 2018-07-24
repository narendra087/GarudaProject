using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class gm14 : MonoBehaviour
{
    public static string currentWord;
    // public static string soal;

    public Transform spellWord;
    public Transform result;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public RectTransform lett5;
    public RectTransform lett6;
    public RectTransform lett7;
    public RectTransform lett8;
    public RectTransform lett9;
    public RectTransform lett10;
    public RectTransform lett11;
    public RectTransform lett12;
    public RectTransform lett13;
    public RectTransform lett14;

    public string soal;

    public static List<string> selectLetter = new List<string>() { "", "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;

    public static int count = 0;
    public static int cek = 0;
    public static int timer = 0;

    // Use this for initialization
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {

        if (popUp14.game == 1)
        {

            spellWord.GetComponent<TMPro.TextMeshProUGUI>().text = currentWord;
            if (currentWord == soal && count == soal.Length)
            {
                cek = 1;
                FindObjectOfType<benar14>().JawabanBenar();
                // result.GetComponent<TextMesh>().text = "Benar";
                lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
                lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
                lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
                lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
                lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
                lett6.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(5, 1);
                lett7.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(6, 1);
                lett8.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(7, 1);
                lett9.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(8, 1);
                lett10.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(9, 1);
                lett11.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(10, 1);
                lett12.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(11, 1);
                lett13.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(12, 1);
                lett14.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(13, 1);
            }
            else if (currentWord != soal && count == soal.Length)
            {
                FindObjectOfType<salah14>().JawabanSalah();
                // result.GetComponent<TextMesh>().text = "Salah";

                //Debug.Log("Anda Salah");
            }

        }
    }

}