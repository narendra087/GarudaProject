﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerAgility : MonoBehaviour {
	public static int level = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		level = PlayerPrefs.GetInt("level", level);
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 1; i < max_level; i++)
		{
			if (i <= level)
			{
				levelUnlocker[i].SetActive(false);
				Debug.Log("" + level);
			}
			else
			{
				levelUnlocker[i].SetActive(true);
				Debug.Log("" + level);
			}
		}
	}

	public static void Next_Level()
	{	
		if(level == NextLevelAgility.thelevel)
		{
			level += 1;
			PlayerPrefs.SetInt("level", level);
		}
	}

	public void Reset()
	{
		level = 1;
		PlayerPrefs.SetInt("level", level);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
