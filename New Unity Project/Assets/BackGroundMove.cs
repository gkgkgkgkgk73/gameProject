using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(58.6293f,-0.0085f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != new Vector3(-58.53f, -0.06f, 0))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position = new Vector3(58.6893f - 0.0085f, 0);
        }
    }
}
