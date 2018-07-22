using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay8 : MonoBehaviour
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
        popUp8.game = 1;
        gm8.currentWord = "";
        gm8.count = 0;
        Debug.Log(popUp8.game + "-" + gm8.count);
        FindObjectOfType<benar8>().Start();

    }
}
