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

    void Start()
    {
        StartCoroutine(AddingDis());
    }

    IEnumerator AddingDis()
    {
        while (true)
        {
            if (!addingDis)
            {
                addingDis = true;
                disrun += 1;
                disDisplay.GetComponent<Text>().text = disrun.ToString();
                yield return new WaitForSeconds(diaplay);
                addingDis = false;
            }
            yield return null;
        }
    }
}
