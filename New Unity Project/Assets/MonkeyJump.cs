using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonkeyJump : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump")) {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 5;
     
        }
     
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestScore) {
            Score.bestScore = Score.score;

        }
        SceneManager.LoadScene("GameOverScene");
    }


}
