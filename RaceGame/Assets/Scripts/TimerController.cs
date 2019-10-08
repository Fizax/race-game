using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    private float startTimer;
    private bool finnished = false;
    public Text ScoreText;
    private string key = "first key";
    float t;
    float myTime = 0;



    // Start is called before the first frame update
    void Start()
    {
        startTimer = Time.time;
        ScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }



    // Update is called once per frame
    void Update()
    {
        if (finnished)
        {
            if(myTime == 0)
            {
                myTime = t;
            }
            if (myTime < PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.GetFloat("HighScore", t);
                ScoreText.text = myTime.ToString();
                PlayerPrefs.SetFloat("HighScore", myTime);
                
            }
            return;
        }

         t = Time.time - startTimer;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

 

    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.yellow;
        float myTime = t;

       
    }
}
