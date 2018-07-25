using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelAgility : MonoBehaviour {
	public int scoreUnlock;
	public GameObject Next_Level;
	public int max_level;
	public string num_level;
	public static int thelevelAgility;
	public int t;
	public string sceneload;
	public string nextLevelScene;
	public Animator Anim;
	public Image Img;

	// Use this for initialization
	void Start () {
		//gmScript.nilai = 0;
		thelevelAgility = PlayerPrefs.GetInt("thelevelAgility", thelevelAgility);
	}
	
	// Update is called once per frame
	void Update () {
		for (int l = 1; l < max_level; l++)
		{
			if(LevelUnlockerAgility.levelAgility == l)
			{
				Next_Level.SetActive(true);
			}
		}
	}

	public static void the_level(int t)
	{
		thelevelAgility = t;
		PlayerPrefs.SetInt("thelevelAgility", thelevelAgility);
	}

	public void next()
	{
		LevelUnlockerAgility.Next_Level();
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
