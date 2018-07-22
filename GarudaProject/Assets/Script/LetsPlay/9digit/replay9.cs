using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay9 : MonoBehaviour
{
    public Button m_YourFirstButton;

    // Use this for initialization
    void Start()
    {
        Button btn1 = m_YourFirstButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void TaskOnClick()
    {
        popUp9.game = 1;
        gm9.currentWord = "";
        gm9.count = 0;
        Debug.Log(popUp9.game + "-" + gm9.count);
        FindObjectOfType<benar8>().Start();

    }
}
