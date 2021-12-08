using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    // Declaring variables to be used for audio
    private AudioSource menuAudio;
    public AudioClip menuClick;

    void Start()
    {
        // Get component will being useed to retieve the audio source 
        menuAudio = GetComponent<AudioSource>();
    }

    // I created four seperate functions, which will use the scenemanager class and loadscene function to load a specfic game scene
    // Also using the playoneshot function to play an audio file.
    // In the quitgame function, I use the Quit function to close the game.
    public void PlayEasy()
    {
        SceneManager.LoadScene(1);
        menuAudio.PlayOneShot(menuClick);
    }

    public void PlayMedium()
    {
        SceneManager.LoadScene(2);
        menuAudio.PlayOneShot(menuClick);
    }

    public void PlayHard()
    {
        SceneManager.LoadScene(3);
        menuAudio.PlayOneShot(menuClick);
    }

    public void QuitGame()
    {
        Application.Quit();
        menuAudio.PlayOneShot(menuClick);
    }
}
