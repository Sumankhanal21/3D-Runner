using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public GameObject[] section;
    public float zpos = 287.2811f;
    public bool creatingsection = false;
    public int secnum;
    public float x = -505.8674f;
    public float y = -131.7906f;
    void Update()
    {
        if (creatingsection == false)
        {
            creatingsection = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secnum = Random.Range(0, 2);
        Instantiate(section[secnum], new Vector3(x, y, zpos), Quaternion.identity);
        zpos += 50;
        yield return new WaitForSeconds(2);
        creatingsection = false;
    }
}
