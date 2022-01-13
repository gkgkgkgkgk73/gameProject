using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReStart : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(onClickButton);
    }
    public void onClickButton()
    {
        SceneManager.LoadScene("GameScene");
  
    }
}
