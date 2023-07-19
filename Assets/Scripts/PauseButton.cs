using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    private GameObject buttonBack;
    private GameObject buttonPause;
    private GameObject buttonPlay;
    private GameObject buttonQuit;
    private GameObject imagePaws;
    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        buttonBack = GameObject.Find("ButtonBack");
        buttonBack.SetActive(false);
        buttonPause = GameObject.Find("ButtonPause");
        buttonPause.SetActive(true);
        buttonPlay = GameObject.Find("ButtonPlay");
        buttonPlay.SetActive(false);
        buttonQuit = GameObject.Find("ButtonQuit");
        buttonQuit.SetActive(false);
        imagePaws = GameObject.Find("ImagePaws");
        imagePaws.SetActive(false);
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName: "SampleScene");
    }

    public void Pause()
    {
        if (paused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void Quit()
    {
        // https://gamedevbeginner.com/how-to-quit-the-game-in-unity/
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    
    void PauseGame()
    {
        buttonBack.SetActive(true);
        buttonPause.SetActive(false);
        buttonPlay.SetActive(true);
        buttonQuit.SetActive(true);
        imagePaws.SetActive(true);
        paused = true;
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        buttonBack.SetActive(false);
        buttonPause.SetActive(true);
        buttonPlay.SetActive(false);
        buttonQuit.SetActive(false);
        imagePaws.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

}
