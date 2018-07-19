using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerSafety : MonoBehaviour {
	public static int levelSafety = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelSafety = PlayerPrefs.GetInt("levelSafety", levelSafety);
	}
	
	// Update is called once per frame
	void Update () {
		for(int m = 1; m < max_level; m++)
		{
			if (m <= levelSafety)
			{
				levelUnlocker[m].SetActive(false);
				Debug.Log("" + levelSafety);
			}
			else
			{
				levelUnlocker[m].SetActive(true);
				Debug.Log("" + levelSafety);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelSafety == NextLevelSafety.thelevelSafety)
		{
			levelSafety += 1;
			PlayerPrefs.SetInt("levelSafety", levelSafety);
		}
	}

	public void Reset()
	{
		levelSafety = 1;
		PlayerPrefs.SetInt("levelSafety", levelSafety);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
