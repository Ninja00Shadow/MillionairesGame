using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float DURATION = 60f;
    public float timeRemaining = 60f;
    public bool timerIsRunning = false;

    public TMP_Text timeText;
    public QuizManager quizManager;

    public void StartTimer()
    {
        timerIsRunning = true;
        timeRemaining = DURATION;
        StartCoroutine(UpdateTimer());
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

    public void ResetText()
    {
        timeText.text = "";
    }

    IEnumerator UpdateTimer()
    {
        while (timerIsRunning && timeRemaining > 0)
        {
            yield return new WaitForSeconds(1f);

            timeRemaining -= 1f;
            if(timerIsRunning) timeText.text = Mathf.FloorToInt(timeRemaining).ToString() + "s";

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerIsRunning = false;
                quizManager.GameOver(true);
            }
        }
    }
}
