﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class benar : MonoBehaviour {
    public Transform transparan;
    public string category;
    public string soal;
    public RectTransform lett1;
    public RectTransform lett2;
    public RectTransform lett3;
    public Image Img;
    public Animator Anim;

    //public static List<string> selectSoal = new List<string>() { "c", "o", "l", "", "", ""};

    public void Start()
    {
       //gmScript.currentWord = "";
       if(gmScript.currentWord == soal)
       {
            lett1.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(0, 1);
            lett2.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(1, 1);
            lett3.GetComponent<TMPro.TextMeshProUGUI>().text = soal.Substring(2, 1);
            popUp.game = 1;
            gmScript.currentWord = "";
        } else
       { 
            transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }

    public void JawabanBenar()
    {
        popUp.game = 0;
        transparan.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Benar");
        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        popUp.game = 0;
        gmScript.count = 0;
        gmScript.currentWord = soal;
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Fade", true);
        popUp.game = 0;
        yield return new WaitUntil(()=>Img.color.a==1);
        SceneManager.LoadScene(category);
    }
}
