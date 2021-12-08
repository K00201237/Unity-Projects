using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    // Declaring variables
    public float timeValue = 90;
    public Text timeText;
    public Text timeOverText;

    private AudioSource timerAudio;
    public AudioClip timesUp;


    void Start()
    {
        timerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Using an if statement to see if time is greater than 0, if it is, I use deltatime to reduce timeValue each second.
        // If time is equal to 0, it loads a new scene.
        if (timeValue > 0)
        {

            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            SceneManager.LoadScene(5);
            timerAudio.PlayOneShot(timesUp);
        }

        DisplayTime(timeValue);
    }

    // I created a new function to disaplay time, the if statement is to confirm that our time is set to 0.
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
            
        }
        

        // I can get the minutes by dividing by 60 and using the Floor to int function to round down to the nearest whole number,
        // To get seconds I can use modular to get the seconds.
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Adding the time to the text object.
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
