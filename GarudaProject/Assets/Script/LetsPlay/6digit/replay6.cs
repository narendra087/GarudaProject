﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay6 : MonoBehaviour
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
        popUp6.game = 1;
        gm6.currentWord = "";
        gm6.count = 0;
        Debug.Log(popUp6.game + "-" + gm6.count);
        FindObjectOfType<benar6>().Start();

    }
}
