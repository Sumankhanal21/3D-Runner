using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScripts : MonoBehaviour
{
    public Animator jumpani;
    public float speed = 3f;
    public float leftright = 4f;
    void Start()
    {
        jumpani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        if (this.gameObject.transform.position.x > BoundaryScript.leftside)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftright, Space.World);
            }
        }
        if (this.gameObject.transform.position.x < BoundaryScript.rightside)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftright, Space.World);
            }
        }

    }
}
