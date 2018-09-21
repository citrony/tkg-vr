using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_rotation_x : MonoBehaviour
{
    public float speed = 1.0f;


    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
//        transform.Rotate (new Vector3 (speed * Time.deltaTime, 0, 0));
        transform.Rotate (speed * Time.deltaTime, 0, 0);
    }
}
