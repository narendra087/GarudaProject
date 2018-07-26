using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static int timeLeft;
    public Transform countdownText;
    public string newscene;

    AudioSource audioData;
    // Use this for initialization

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        timeLeft = 10;
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = (timeLeft + " ");
        if (timeLeft == 0)
        {
            StopCoroutine("LoseTime");
            GetComponent<TMPro.TextMeshProUGUI>().text = "Times Up!";
            gm4.currentWord = "";
            gm4.count = 0;
            gm5.currentWord = "";
            gm5.count = 0;
            gm6.currentWord = "";
            gm6.count = 0;
            gm7.currentWord = "";
            gm7.count = 0;
            gm8.currentWord = "";
            gm8.count = 0;
            gm9.currentWord = "";
            gm9.count = 0;
            gm10.currentWord = "";
            gm10.count = 0;
            gm11.currentWord = "";
            gm11.count = 0;
            gm14.currentWord = "";
            gm14.count = 0;
            audioData.Play();
            SceneManager.LoadScene(newscene);
            //SceneManager.LoadScene(newscene);
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
