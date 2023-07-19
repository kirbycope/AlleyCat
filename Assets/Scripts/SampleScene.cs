using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SampleScene : MonoBehaviour
{

    private bool muted;

    // Start is called before the first frame update
    void Start()
    {
        muted = false;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mute()
    {
        if (muted)
        {
            muted = false;
            AudioListener.volume = 1;
        }
        else
        {
            muted = true;
            AudioListener.volume = 0;
        }
    }

    public void Play()
    {
       SceneManager.LoadScene(sceneName: "Alley");
    }

}
