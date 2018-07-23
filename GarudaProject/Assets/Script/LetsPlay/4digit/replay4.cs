using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay4 : MonoBehaviour
{
    public Button m_YourFirstButton;

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
        popUp4.game = 1;
        gm4.currentWord = "";
        gm4.count = 0;
        Debug.Log(popUp4.game + "-" + gm4.count);
        FindObjectOfType<benar4>().Start();

    }
}
