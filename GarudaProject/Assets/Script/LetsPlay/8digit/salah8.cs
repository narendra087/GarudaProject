using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salah8 : MonoBehaviour
{
    public Transform transparan;

    private void Start()
    {
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);

    }
    public void JawabanSalah()
    {
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        //Debug.Log("Muncul Icon");
        popUp8.game = 0;
        gm8.cek = 0;
        //Debug.Log("Muncul");
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        transparan.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        popUp8.game = 1;
        gm8.count = 0;
        gm8.currentWord = "";

    }

}
