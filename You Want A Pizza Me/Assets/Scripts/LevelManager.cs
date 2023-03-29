using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    static LevelManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("mainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public static void LoadLoseScene()
    {
        SceneManager.LoadScene("LoseScene");
    }

    public static void LoadWinScene()
    {
        SceneManager.LoadScene("WinScene");
    }
}
