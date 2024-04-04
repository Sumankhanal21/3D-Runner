using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public static float leftside = 6.0f;
    public static float rightside = 19.8f;
    public float left;
    public float right;
  
    
    public void Start()
    {

        left = leftside;
        right = rightside;
        
    }


    void Update()
    {

    }
}
