using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject menu;

    [SerializeField]
    private bool isPaused = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Pause()
    {
        menu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Unpause()
    {
        menu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void SaveGame()
    {

    }

    public void NewGame()
    {


        Unpause();
    }

    public void LoadGame()
    {

    }

    public void SaveAsJSON()
    {

    }
}