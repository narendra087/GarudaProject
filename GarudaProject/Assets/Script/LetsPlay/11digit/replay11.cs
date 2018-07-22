using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replay11 : MonoBehaviour
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

    private void OnMouseDown()
    {
        popUp11.game = 1;
        gm11.currentWord = "";
        gm11.count = 0;
        Debug.Log(popUp11.game + "-" + gm11.count);
        FindObjectOfType<benar11>().Start();

    }
}
