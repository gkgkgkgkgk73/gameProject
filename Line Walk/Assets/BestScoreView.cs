using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "BestScore: " + ScoreManage.bestScore.ToString();
    }


    private void Update()
    {
        GetComponent<Text>().text = "BestScore: " + ScoreManage.bestScore.ToString();
    }


}
