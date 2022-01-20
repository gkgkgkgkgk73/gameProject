using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(restart);
    }

    // Update is called once per frame
    void restart() 
    {
        SceneManager.LoadScene("GameScene");
    
    }
}
