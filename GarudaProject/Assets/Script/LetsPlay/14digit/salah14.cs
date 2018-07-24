using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salah14 : MonoBehaviour
{
    public RectTransform transparan;
    AudioSource audioData;

    private void Start()
    {
        audioData = GetComponent<AudioSource>();
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);

    }
    public void JawabanSalah()
    {
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Muncul Icon");
        popUp14.game = 0;
        gm14.cek = 0;
        //Debug.Log("Muncul");
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        audioData.Play();
        yield return new WaitForSeconds(0.5f);
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        popUp14.game = 1;
        gm14.count = 0;
        gm14.currentWord = "";

    }

}
