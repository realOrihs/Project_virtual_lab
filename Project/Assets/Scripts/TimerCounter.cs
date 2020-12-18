using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerCounter : MonoBehaviour
{
    private float timeInSecondsP;
    public static int minutsP;
    public static int secondsP;
    public Text minutes;
    public Text seconds;

    internal void Update()
    {
        
                timeInSecondsP += Time.deltaTime;

                secondsP = (int)(timeInSecondsP % 60);
                minutsP = (int)(timeInSecondsP / 60);

                if (minutsP < 10)
                {
                    minutes.text = 0 + minutsP.ToString();
                    if (secondsP < 10)
                    {
                        seconds.text = 0 + secondsP.ToString();
                    }
                    else
                    {
                        seconds.text = secondsP.ToString();
                    }
                }
                else
                {
                    minutes.text = 0 + minutsP.ToString();
                    if (secondsP < 10)
                    {
                        seconds.text = 0 + secondsP.ToString();
                    }
                    else
                    {
                        seconds.text = secondsP.ToString();
                    }
                }
            {
                string secondsP;
                string minutsP;
            }
    }
}