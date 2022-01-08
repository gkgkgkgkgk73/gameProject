using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
 

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score++;
        if (ScoreManager.bestScore < ScoreManager.score)
        {
            
            ScoreManager.bestScore = ScoreManager.score;
        }


    }
}
