using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay7 : MonoBehaviour
{

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
        popUp7.game = 1;
        gm7.currentWord = "";
        gm7.count = 0;
        Debug.Log(popUp7.game + "-" + gm7.count);
        FindObjectOfType<benar7>().Start();

    }
}
