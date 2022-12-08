using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour

    
{
    //private float speed = -10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0f, 0f);//-x
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0f, 0f);//+x
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, 0.1f, 0f);//+y
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -0.1f, 0f);//-y
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0f, 0f, 0.1f);//+z
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += new Vector3(0f, 0f, -0.1f);//-z
        }

    }
}

