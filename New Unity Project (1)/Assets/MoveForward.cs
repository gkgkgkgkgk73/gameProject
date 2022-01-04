using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(7.78f,-3.3f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -9.29f)
        {
            transform.position += Vector3.left * 3 * Time.deltaTime;
        }
        else SceneManager.LoadScene("GameScene");
    }
}
