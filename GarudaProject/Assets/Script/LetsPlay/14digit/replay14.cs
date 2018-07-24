using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay14 : MonoBehaviour
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
        popUp14.game = 1;
        gm14.currentWord = "";
        gm14.count = 0;
        Debug.Log(popUp14.game + "-" + gm14.count);
        FindObjectOfType<benar14>().Start();

    }
}
