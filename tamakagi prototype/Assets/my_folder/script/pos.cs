﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
}