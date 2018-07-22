using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay10 : MonoBehaviour
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
        popUp10.game = 1;
        gm10.currentWord = "";
        gm10.count = 0;
        Debug.Log(popUp10.game + "-" + gm10.count);
        FindObjectOfType<benar10>().Start();

    }
}
