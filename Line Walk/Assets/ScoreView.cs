using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: 0";
    }

    private void Update()
    {
        GetComponent<Text>().text = "Score: " + ScoreManage.score.ToString();
    }


}
