using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    public static int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameObject.Find("Score").GetComponent<Text>().text = "Score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Score").GetComponent<Text>().text = "Score:" + score;
    }
}
