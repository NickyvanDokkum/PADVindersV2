﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenShenanigans : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0); //This loads the game scene
    }
}
