﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar4 : MonoBehaviour
{
    public Transform transparan;
    public string category;
    public string soal;

    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public RectTransform lett4;
    public Image Img;
    public Animator Anim;
    public string cat;

    //public static List<string> selectSoal = new List<string>() { "c", "o", "l", "", "", ""};

    public void Start()
    {
        // gmScript.currentWord = "";
        if (gm4.currentWord == soal)
        {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            lett4.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(3, 1);
            popUp4.game = 0;
            gm4.currentWord = "";
        }
        else
        {
            gm4.currentWord = "";
            transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }

    public void JawabanBenar()
    {

        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Benar");
        
        Debug.Log("Next Level");
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        popUp4.game = 0;
        gm4.count = 0;
        gm4.currentWord = soal;
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
