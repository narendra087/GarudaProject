﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoop : MonoBehaviour {

     void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}

