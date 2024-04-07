using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStarter : MonoBehaviour
{
    public GameObject count3;
    public GameObject count2;
    public GameObject count1;
    public GameObject countgo;
    public AudioSource ready;
    public AudioSource go;
    
   
    
    void Start()
    {
        StartCoroutine(CountSequence());
    }

   IEnumerator CountSequence()
    {
        
        yield return new WaitForSeconds(1);
        count3.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1);
        count2.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1);
        count1.SetActive(true);
        ready.Play();
        yield return new WaitForSeconds(1);
        countgo.SetActive(true);
        go.Play();

    }
}
