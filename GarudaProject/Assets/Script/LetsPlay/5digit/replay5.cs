using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay5 : MonoBehaviour
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
        popUp5.game = 1;
        gm5.currentWord = "";
        gm5.count = 0;
        Debug.Log(popUp5.game + "-" + gm5.count);
        FindObjectOfType<benar5>().Start();

    }
}
