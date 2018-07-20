using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerAgility : MonoBehaviour {
	public static int levelAgility = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelAgility = PlayerPrefs.GetInt("levelAgility", levelAgility);
	}
	
	// Update is called once per frame
	void Update () {
		for(int l = 1; l < max_level; l++)
		{
			if (l <= levelAgility)
			{
				levelUnlocker[l].SetActive(false);
				Debug.Log("" + levelAgility);
			}
			else
			{
				levelUnlocker[l].SetActive(true);
				Debug.Log("" + levelAgility);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelAgility == NextLevelAgility.thelevelAgility)
		{
			levelAgility += 1;
			PlayerPrefs.SetInt("levelAgility", levelAgility);
		}
	}

	public void Reset()
	{
		levelAgility = 1;
		PlayerPrefs.SetInt("levelAgility", levelAgility);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
