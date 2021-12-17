using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // keeps track of whether or not the game is paused
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // game is not paused until escape button is pressed
            if (GameIsPaused)
            {
                Resume();
            else
            {
                Pause()
            }
            }
        }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        // resumes or continues gameplay
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    [
        pauseMenuUI.SetActive(true);
        // freezes gameplay
        Time.timeScale = 0f;
        GameIsPaused = true;

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting game...")
    }
    ]
}
