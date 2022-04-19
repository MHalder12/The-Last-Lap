using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] Text Timertext;
    public static float timer;
    public static bool timeStarted = false;

    private void Update()
    {
       
            timer += Time.deltaTime;
        
            Timertext.text = Mathf.Floor(timer).ToString();
    }

    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string Time = string.Format("{0:0}:{1:00}", minutes, seconds);
        Timertext.text = Time;
        //GUI.Label(new Rect(10, 10, 250, 100), Time);
    }
}
