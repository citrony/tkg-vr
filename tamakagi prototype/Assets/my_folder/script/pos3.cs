using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos3 : MonoBehaviour {
        // Use this for initialization
        void Start()
        {
            GetComponent<Renderer>().enabled = false;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.F3))
            {
                GetComponent<Renderer>().enabled = true;
            }

            if (Input.GetKey(KeyCode.Alpha3))
            {
                GetComponent<Renderer>().enabled = false;
            }
        }
    }

 
