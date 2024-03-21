using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public static float leftside = -324.8f;
    public static float rightside=-318.56f;
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
