using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void ChangeScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);

    }

    public static void QuitGame()
    {
        Debug.Log("Quit Game");
    }
}