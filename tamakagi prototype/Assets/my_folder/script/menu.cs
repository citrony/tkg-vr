using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
    RaycastHit hit;
    bool flg = false;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            GetComponent<Renderer>().enabled = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 3.0f;
            Ray ray = Camera.main.ScreenPointToRay(pos);

            Vector3 newpos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = newpos;
        }

        if (Input.GetKey(KeyCode.Delete))
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
}
