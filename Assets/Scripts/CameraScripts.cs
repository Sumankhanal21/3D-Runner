using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScripts : MonoBehaviour
{
     public Transform pos;
    public Vector3 distance;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = pos.position - distance;
    }
    
}
