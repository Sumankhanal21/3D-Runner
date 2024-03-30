using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
   // private int coins = 0;
    //public int rotate = 1;
    public AudioSource touchsound;
   // void Update()
   // {
     //   transform.Rotate(0, rotate, 0, Space.World);
   // }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.transform.tag == "coin") { 
            touchsound.Play();
        this.gameObject.SetActive(false);
           // coins++;
           // Debug.Log(coins);

      //  }
    }
}
