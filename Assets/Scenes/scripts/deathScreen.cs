using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class deathtoprefabs : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MainMenu() 
    {

        SceneManager.LoadSceneAsync(0);
    }
}
