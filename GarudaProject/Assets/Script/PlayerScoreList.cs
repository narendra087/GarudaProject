using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreList : MonoBehaviour
{

    public GameObject playerScoreEntryPrefab1;
    public GameObject playerScoreEntryPrefab2;
    public GameObject playerScoreEntryPrefab3;
    public GameObject playerScoreEntryPrefab4;
    //public Transform ranking;

    ScoreManager scoreManager;
    int lastChangeCounter;
    int i;
    public static int urutan = 1;

    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        lastChangeCounter = scoreManager.GetChangeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager == null)
        {
            Debug.LogError("Error");
            return;
        }

        if (scoreManager.GetChangeCounter() == lastChangeCounter)
        {
            return;
        }

        lastChangeCounter = scoreManager.GetChangeCounter();

        while (this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = scoreManager.GetPlayerNames("Score");

        for (i = 0; i <= names.Length; i++)
        {
            if (i < names.Length)
            {
                if (i == 0)
                {
                    GameObject go1 = (GameObject)Instantiate(playerScoreEntryPrefab1);
                    go1.transform.SetParent(this.transform);
                    //go1.transform.Find("Rank").GetComponent<TMPro.TextMeshProUGUI>().text = i + 1.ToString();
                    go1.transform.Find("Username").GetComponent<TMPro.TextMeshProUGUI>().text = names[0];
                    go1.transform.Find("ID Pegawai").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[0], "ID Pegawai").ToString();
                    //go.transform.Find("Divisi").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Divisi").ToString();
                    go1.transform.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[0], "Score").ToString();
                }

                else if (i == 1)
                {
                    GameObject go2 = (GameObject)Instantiate(playerScoreEntryPrefab2);
                    go2.transform.SetParent(this.transform);
                    //go2.transform.Find("Rank").GetComponent<TMPro.TextMeshProUGUI>().text = i + 1.ToString();
                    go2.transform.Find("Username").GetComponent<TMPro.TextMeshProUGUI>().text = names[1];
                    go2.transform.Find("ID Pegawai").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[1], "ID Pegawai").ToString();
                    //go.transform.Find("Divisi").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Divisi").ToString();
                    go2.transform.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[1], "Score").ToString();

                }

                else if (i == 2)
                {
                    GameObject go3 = (GameObject)Instantiate(playerScoreEntryPrefab3);
                    go3.transform.SetParent(this.transform);
                    //go3.transform.Find("Rank").GetComponent<TMPro.TextMeshProUGUI>().text = i + 1.ToString();
                    go3.transform.Find("Username").GetComponent<TMPro.TextMeshProUGUI>().text = names[2];
                    go3.transform.Find("ID Pegawai").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[2], "ID Pegawai").ToString();
                    //go.transform.Find("Divisi").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Divisi").ToString();
                    go3.transform.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[2], "Score").ToString();
                }

                else if (i >= 3)
                {
                    GameObject go4 = (GameObject)Instantiate(playerScoreEntryPrefab4);
                    go4.transform.SetParent(this.transform);
                    go4.transform.Find("Rank").GetComponent<TMPro.TextMeshProUGUI>().text = (1+i).ToString();
                    go4.transform.Find("Username").GetComponent<TMPro.TextMeshProUGUI>().text = names[i];
                    go4.transform.Find("ID Pegawai").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[i], "ID Pegawai").ToString();
                    //go.transform.Find("Divisi").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(name, "Divisi").ToString();
                    go4.transform.Find("Score").GetComponent<TMPro.TextMeshProUGUI>().text = scoreManager.GetScore(names[i], "Score").ToString();
                }
            }

            else if (i == names.Length)
            {
                return;
            }
        }
    }
}
