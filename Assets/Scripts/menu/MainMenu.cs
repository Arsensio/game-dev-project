using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public VideoPlayer videoPlayer;
    public TMP_Text video_playPause_text;

    void Start() 
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;
    }

    public void ToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadSceneAsync(string scene)
    {
        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
    }

    public void UnloadSceneAsync(string scene)
    {
        SceneManager.UnloadSceneAsync(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            video_playPause_text.SetText("Pause");
        }
        else
        {
            videoPlayer.Play();
            video_playPause_text.SetText("Play");
        }
    }

    public void toggleGameObject(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

}
