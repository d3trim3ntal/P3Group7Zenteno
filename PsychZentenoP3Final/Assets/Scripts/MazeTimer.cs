using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class MazeTimer : MonoBehaviour
{
    public float timerValue;

    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        if(timerValue > 0)
        {
            timerValue -= Time.deltaTime;
        }
        else
        {
            timerValue = 0;
        }

        DisplayTime(timerValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if(timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
