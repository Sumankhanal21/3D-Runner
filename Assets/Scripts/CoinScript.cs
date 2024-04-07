using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int rotate = 2;
   
    void Update()
    {
        transform.Rotate(0, rotate, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        coinUI.coinCount += 1;
        if (other.tag == "Player") {

            Destroy(gameObject);
        }
    }
}
