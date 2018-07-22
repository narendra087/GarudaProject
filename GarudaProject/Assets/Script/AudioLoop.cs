using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoop : MonoBehaviour {

    static int masukOn = 1;

   
    void Update()
    {
        if (masukOn == 1)
        {
            DontDestroyOnLoad(transform.gameObject);
            masukOn = masukOn - 1;
            Debug.Log(masukOn);

        }
        else
        {

        }
    }

}

