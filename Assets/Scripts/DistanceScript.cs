using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScript : MonoBehaviour
{
    public GameObject disDisplay;
    public int disrun;
    public bool addingDis = false;
    public float diaplay = 0.35f;

    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
          //  StartCoroutine(addingDis());
        }
    }
    IEnumerator addingdis()
    {
        disrun = +1;
        disDisplay.GetComponent<Text>().text = "" + disrun;
        yield return new WaitForSeconds(diaplay);
        addingDis = false;
    }
}
