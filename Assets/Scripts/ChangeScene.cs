using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    //Script atacheado a la cámara

    Scene curretScene; 

    
    void Start()
    {
        curretScene = SceneManager.GetActiveScene(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChanger()
    {
        if (curretScene.name == "Instructions")
        {
            SceneManager.LoadScene("Game");
        }
        if (curretScene.name == "Game")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (curretScene.name == "GameOver")
        {
            SceneManager.LoadScene("Instructions"); 
        }

    }
}
