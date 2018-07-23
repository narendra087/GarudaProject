using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static int timeLeft;
    public Transform countdownText;
    public string newscene;
    // Use this for initialization

    void Start()
    {
        timeLeft = 10;
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = (timeLeft + " ");

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            GetComponent<TMPro.TextMeshProUGUI>().text = "Times Up!";
            SceneManager.LoadScene(newscene);
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
