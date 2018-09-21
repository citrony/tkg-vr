using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_lookat : MonoBehaviour
{

    public GameObject targetObj;
    public float speed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetObj.transform);
        transform.position += transform.forward.normalized * speed * Time.deltaTime;
    }
}
