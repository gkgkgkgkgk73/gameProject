using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManage : MonoBehaviour
{

    public static float score;
    public static float bestScore=0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score +=  Time.deltaTime;

        if (bestScore < score) 
        {
            bestScore = score;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
