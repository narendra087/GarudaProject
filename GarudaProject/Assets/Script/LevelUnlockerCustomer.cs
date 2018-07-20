using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlockerCustomer : MonoBehaviour {
	public static int levelCustomer = 1;
	public int max_level;
	public GameObject[] levelUnlocker;
	public string loads;
	// Use this for initialization
	void Start () {
		levelCustomer = PlayerPrefs.GetInt("levelCustomer", levelCustomer);
	}
	
	// Update is called once per frame
	void Update () {
		for(int k = 1; k < max_level; k++)
		{
			if (k <= levelCustomer)
			{
				levelUnlocker[k].SetActive(false);
				Debug.Log("" + levelCustomer);
			}
			else
			{
				levelUnlocker[k].SetActive(true);
				Debug.Log("" + levelCustomer);
			}
		}
	}

	public static void Next_Level()
	{	
		if(levelCustomer == NextLevelCustomer.thelevelCustomer)
		{
			levelCustomer += 1;
			PlayerPrefs.SetInt("levelCustomer", levelCustomer);
		}
	}

	public void Reset()
	{
		levelCustomer = 1;
		PlayerPrefs.SetInt("levelCustomer", levelCustomer);
	}

	public void add_level()
	{
		Next_Level();
		SceneManager.LoadScene(loads);
	}

}
