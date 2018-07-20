using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelCustomer : MonoBehaviour {
	public int scoreUnlock;
	public GameObject Next_Level;
	public int max_level;
	public string num_level;
	public static int thelevelCustomer;
	public int t;
	public string sceneload;
	public string nextLevelScene;
	public Animator Anim;
	public Image Img;

	// Use this for initialization
	void Start () {
		gmScript.nilai = 0;
		thelevelCustomer = PlayerPrefs.GetInt("thelevelCustomer", thelevelCustomer);
	}
	
	// Update is called once per frame
	void Update () {
		for (int k = 1; k < max_level; k++)
		{
			if(LevelUnlockerCustomer.levelCustomer == k)
			{
				Next_Level.SetActive(true);
			}
		}
	}

	public static void the_level(int t)
	{
		thelevelCustomer = t;
		PlayerPrefs.SetInt("thelevelCustomer", thelevelCustomer);
	}

	public void next()
	{
		LevelUnlockerCustomer.Next_Level();
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
