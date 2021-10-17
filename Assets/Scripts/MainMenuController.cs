using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void play(){
        SceneManager.LoadScene("Game");
    }

    public void Exit(){
        Application.Quit();
    }
}
