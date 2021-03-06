﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelIntegrity : MonoBehaviour {
	public int scoreUnlock;
	public GameObject Next_Level;
	public int max_level;
	public string num_level;
	public static int thelevelIntegrity;
	public int t;
	public string sceneload;
	public string nextLevelScene;
	public Animator Anim;
	public Image Img;

	// Use this for initialization
	void Start () {
		gmScript.nilai = 0;
		thelevelIntegrity = PlayerPrefs.GetInt("thelevelIntegrity", thelevelIntegrity);
	}
	
	// Update is called once per frame
	void Update () {
		for (int j = 1; j < max_level; j++)
		{
			if(LevelUnlockerIntegrity.levelIntegrity == j)
			{
				Next_Level.SetActive(true);
			}
		}
	}

	public static void the_level(int t)
	{
		thelevelIntegrity = t;
		PlayerPrefs.SetInt("thelevelIntegrity", thelevelIntegrity);
	}

	public void next()
	{
		LevelUnlockerIntegrity.Next_Level();
		SceneManager.LoadScene(sceneload);
	}

	public void _level()
	{
		the_level(t);
		StartCoroutine(anima());
	}

	IEnumerator anima()
	{
		Anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>Img.color.a==1);
		SceneManager.LoadScene(nextLevelScene);
	}

}
