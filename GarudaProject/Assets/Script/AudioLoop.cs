using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoop : MonoBehaviour {

    private bool masukOn = true;

    void Start()
    {
        masukOn = true;

    }
    void Update()
    {
        if (masukOn == true)
        {
            DontDestroyOnLoad(transform.gameObject);
            masukOn = false;

        }
        else
        {

        }
    }

}

