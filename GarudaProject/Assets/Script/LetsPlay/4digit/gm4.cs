using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class gm4 : MonoBehaviour
{
    public static string currentWord;
    // public static string soal;

    public Transform spellWord;
    public Transform result;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;


    public string soal = "";

    public static List<string> selectLetter = new List<string>() { "", "", "", "", "" };
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

        if (popUp4.game == 1)
        {

            spellWord.GetComponent<TMPro.TextMeshProUGUI>().text = currentWord;
            if (currentWord == soal && count == soal.Length)
            {
                cek = 1;
                FindObjectOfType<benar4>().JawabanBenar();
                lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
                lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
                lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
                lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            }
            else if (currentWord != soal && count == soal.Length)
            {
                FindObjectOfType<salah4>().JawabanSalah();
            }

        }
    }
    

}