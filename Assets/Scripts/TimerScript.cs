using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    private float startTime;
    public bool stop = false;
    public static int timer;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    	if(stop)
    	{
    		return;
    	}

        float t = Time.time - startTime;
        timer = (int)t;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds + "s";
    }

}
