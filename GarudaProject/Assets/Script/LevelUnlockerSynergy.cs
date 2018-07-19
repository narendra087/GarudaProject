using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerSynergy : MonoBehaviour {
	public static int levelSynergy = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelSynergy = PlayerPrefs.GetInt("levelSynergy", levelSynergy);
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 1; i < max_level; i++)
		{
			if (i <= levelSynergy)
			{
				levelUnlocker[i].SetActive(false);
				Debug.Log("" + levelSynergy);
			}
			else
			{
				levelUnlocker[i].SetActive(true);
				Debug.Log("" + levelSynergy);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelSynergy == NextLevelSynergy.thelevelSynergy)
		{
			levelSynergy += 1;
			PlayerPrefs.SetInt("levelSynergy", levelSynergy);
		}
	}

	public void Reset()
	{
		levelSynergy = 1;
		PlayerPrefs.SetInt("levelSynergy", levelSynergy);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
