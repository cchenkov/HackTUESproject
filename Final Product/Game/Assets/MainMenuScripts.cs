﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour {
    public void StartFunc()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitFunc()
    {
        Time.timeScale = 1f;
        
        Application.Quit();
    }
}
