using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    int speed = 2;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed;
        }
    }
}
