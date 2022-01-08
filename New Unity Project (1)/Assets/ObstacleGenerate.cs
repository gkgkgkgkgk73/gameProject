using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerate : MonoBehaviour
{
    public GameObject obstacle;

    public float timediff;
    float timer = 0;
    float level = 2f;
    float gravityMax = 1f;
    float gravityMin = 1f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timediff = Random.Range(level, 2f);
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            GameObject newObstacle = Instantiate(obstacle);
            float x = Random.Range(-8.5f, 8.82f);
            newObstacle.transform.position = new Vector3(x, 5.39f, 0);
            newObstacle.GetComponent<Rigidbody2D>().gravityScale = Random.Range(gravityMin,gravityMax);

            timer = 0;
            Destroy(newObstacle, 7);
            if (level > 0)
            {
                level -= 0.1f;
            }

            if (gravityMax < 4)
            {
                gravityMax += 0.1f;
            }

            if (gravityMin > 0.5f)
            {
                gravityMin -= 0.1f;
            }
        }
       

    }

}
