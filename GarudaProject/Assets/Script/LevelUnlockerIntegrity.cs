using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerIntegrity : MonoBehaviour {
	public static int levelIntegrity = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelIntegrity = PlayerPrefs.GetInt("levelIntegrity", levelIntegrity);
	}
	
	// Update is called once per frame
	void Update () {
		for(int j = 1; j < max_level; j++)
		{
			if (j <= levelIntegrity)
			{
				levelUnlocker[j].SetActive(false);
				Debug.Log("" + levelIntegrity);
			}
			else
			{
				levelUnlocker[j].SetActive(true);
				Debug.Log("" + levelIntegrity);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelIntegrity == NextLevelIntegrity.thelevelIntegrity)
		{
			levelIntegrity += 1;
			PlayerPrefs.SetInt("levelIntegrity", levelIntegrity);
		}
	}

	public void Reset()
	{
		levelIntegrity = 1;
		PlayerPrefs.SetInt("levelIntegrity", levelIntegrity);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
