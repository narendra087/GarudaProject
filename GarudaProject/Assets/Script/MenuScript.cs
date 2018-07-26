using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public string sceneName;
	public Animator Anim;
	public Image Img;
    public static int nilaiSimpanan;

    public void ChangeScene()
    {
        StartCoroutine(Fade());
        // SceneManager.LoadScene(sceneName);
    }

    IEnumerator Fade()
    {
        Anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        SceneManager.LoadScene(sceneName);
    }

    public void Update()
    {
        nilaiSimpanan = scoreS.nilai;
    }


}
