﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUp4 : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;
    public static int game;

    void Start()
    {
        game = 1;
        Button btn1 = m_YourFirstButton.GetComponent<Button>();

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (game == 1) 
        {
            //Debug.Log("tempe");
            gm4.cek = 1;
            gm4.count++;
            //gmScript.currentWord += GetComponent<SpriteRenderer>().sprite.name;
            //gmScript.currentWord += EventSystem.current.currentSelectedGameObject.name;
            gm4.currentWord += GetComponent<TextMesh>().text;

            gm4.letterNum += 1;
            // gmScript.selectLetter[gmScript.letterNum] = GetComponent<SpriteRenderer>().sprite.name;
            // gmScript.selectLetter[gmScript.letterNum] = EventSystem.current.currentSelectedGameObject.name;
            gm4.selectLetter[gm4.letterNum] = GetComponent<TextMesh>().text;
            Debug.Log("Count = " + gm4.count);
            Debug.Log(game);
        }
    }
}