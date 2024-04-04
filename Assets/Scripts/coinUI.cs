using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinUI : MonoBehaviour
{
   
  public static  int coinCount;
    public GameObject dispaly;
    void Update()
    {
        dispaly.GetComponent< Text > ().text = "" + coinCount;
    }
}
