using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos2 : MonoBehaviour {

        // Use this for initialization
        void Start()
        {
            GetComponent<Renderer>().enabled = false;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.F2))
            {
                GetComponent<Renderer>().enabled = true;
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                GetComponent<Renderer>().enabled = false;
            }
        }
    }
