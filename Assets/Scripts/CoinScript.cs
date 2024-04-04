using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    
   private int coins = 0;
    public int rotate = 2;
    
    
    void Update()
    {
        transform.Rotate(0, rotate, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player") {
           
           
             coins=coins+1;
             Debug.Log(coins);
            Destroy(gameObject);
         

        }
    }
}
