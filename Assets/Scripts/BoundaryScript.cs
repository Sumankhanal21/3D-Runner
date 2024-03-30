using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public static float leftside = 5.4f;
    public static float rightside = 18.1f;
    public float left;
    public float right;
    void Start()
    {
        left = leftside;
        right = rightside;
    }


    void Update()
    {

    }
}
