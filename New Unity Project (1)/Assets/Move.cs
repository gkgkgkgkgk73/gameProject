using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.06f, -3.43f, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            animator.SetBool("run",true);
            transform.Translate(Vector3.left*Time.deltaTime*4);
            transform.localScale = new Vector3(5, 5, 5);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            animator.SetBool("run", true);
            transform.Translate(Vector3.right*Time.deltaTime*4);
            transform.localScale = new Vector3(-5, 5, 5);
        }
        else 
        { 
            animator.SetBool("run", false);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        SceneManager.LoadScene("GameOverScene");

    }
}
