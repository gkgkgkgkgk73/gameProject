using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTree : MonoBehaviour
{

    public GameObject tree;
    public GameObject banana;

    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timediff = Random.Range(2.0f,6.0f);
        timer += Time.deltaTime;
        if (timer > timediff) {

            GameObject newtree = Instantiate(tree);
            GameObject newBanana = Instantiate(banana);
            float y = Random.Range(-4.08f, -0.3f);
            newtree.transform.position = new Vector3(11.67f,y,0);
            newBanana.transform.position = new Vector3(12.01f,(y+3.99f),0);
            timer = 0;
            //Destroy(newtree,15);
        }
    }

}
