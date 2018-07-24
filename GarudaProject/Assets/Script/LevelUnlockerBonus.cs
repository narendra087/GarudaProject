using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerBonus : MonoBehaviour {
	public static int levelBonus = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelBonus = PlayerPrefs.GetInt("levelBonus", levelBonus);
	}
	
	// Update is called once per frame
	void Update () {
		for(int l = 1; l < max_level; l++)
		{
			if (l <= levelBonus)
			{
				levelUnlocker[l].SetActive(false);
				Debug.Log("" + levelBonus);
			}
			else
			{
				levelUnlocker[l].SetActive(true);
				Debug.Log("" + levelBonus);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelBonus == NextLevelBonus.thelevelBonus)
		{
			levelBonus += 1;
			PlayerPrefs.SetInt("levelBonus", levelBonus);
		}
	}

	public void Reset()
	{
		levelBonus = 1;
		PlayerPrefs.SetInt("levelBonus", levelBonus);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
