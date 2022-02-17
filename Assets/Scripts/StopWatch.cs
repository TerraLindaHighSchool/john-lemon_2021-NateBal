using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StopWatch : MonoBehaviour
{
    public float timeStart;
    public float newScore;
    private TextMeshProUGUI StopwatchText;

    bool timer = false;

    void Start()
    {
        timeStart = 0;
        timer = true;
        StopwatchText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timer)
        {
            timeStart += Time.deltaTime;
            StopwatchText.text = Mathf.FloorToInt(timeStart).ToString();
        }
    }
}
