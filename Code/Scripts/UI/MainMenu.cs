﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SelectLevel() {
        SceneManager.LoadScene("LevelSelect");
    }
    public void OpenHelp() {
        SceneManager.LoadScene("MainHelp");
    }
    public void OpenCredits() {
        SceneManager.LoadScene("Credits");
    }
}
