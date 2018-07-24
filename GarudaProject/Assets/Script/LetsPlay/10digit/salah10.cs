using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salah10 : MonoBehaviour
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
        popUp10.game = 0;
        gm10.cek = 0;
        //Debug.Log("Muncul");
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        audioData.Play();
        yield return new WaitForSeconds(0.5f);
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        popUp10.game = 1;
        gm10.count = 0;
        gm10.currentWord = "";

    }

}
