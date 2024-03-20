using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Animator jumpani;
    public float speed = 5f;
    public float leftright = 4f;
    void Start()
    {
        jumpani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftright, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * leftright, Space.World);
        }

        /*   if (Input.GetKeyDown(KeyCode.Space))
           {
               jumpani.SetBool("jump", true);
           }*/

    }
}
