using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
   private int coins = 0;
    public int rotate = 2;
    //public AudioSource touchsound;
    void Update()
    {
        transform.Rotate(0, rotate, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
          //  touchsound.Play();
             //this.gameObject.SetActive(false);
             coins++;
             Debug.Log(coins);
            Destroy(gameObject);
          //  Destroy(other.gameObject);

        }
    }
}
