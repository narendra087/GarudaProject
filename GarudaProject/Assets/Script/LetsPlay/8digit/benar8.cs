﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar8 : MonoBehaviour
{
    public RectTransform transparan;
    public string category;
    public string soal;
    public string cat;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public RectTransform lett5;
    public RectTransform lett6;
    public RectTransform lett7;
    public RectTransform lett8;
    public Image Img;
    public Animator Anim;
    AudioSource audioData;

    //public static List<string> selectSoal = new List<string>() { "c", "o", "l", "", "", ""};

    public void Start()
    {
        // gmScript.currentWord = "";
        audioData = GetComponent<AudioSource>();
        if (gm8.currentWord == soal)
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            lett5.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(4, 1);
            lett6.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(5, 1);
            lett7.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(6, 1);
            lett8.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(7, 1);
            popUp8.game = 0;
            gm8.currentWord = "";
        }
        else
        {
            gm8.currentWord = "";
            transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
    }

    public void JawabanBenar()
    {

        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        Debug.Log("Next Level");
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        audioData.Play();
        popUp8.game = 0;
        gm8.count = 0;
        gm8.currentWord = soal;
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        if(cat == "Synergy")
        {
            FindObjectOfType<NextLevelSynergy>().next();
        } else if (cat == "Integrity")
        {
            FindObjectOfType<NextLevelIntegrity>().next();
        } else if (cat == "Customer Focus")
        {
            FindObjectOfType<NextLevelCustomer>().next();
        } else if (cat == "Agility")
        {
            FindObjectOfType<NextLevelAgility>().next();
        } else
        {
            FindObjectOfType<NextLevelSafety>().next();
        }
    }
}
