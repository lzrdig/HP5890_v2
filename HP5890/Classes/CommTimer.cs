﻿using System.Timers;

/// <summary>
/// Summary description for CommTimer
/// </summary>
public class CommTimer
{
    public Timer tmrComm = new Timer();
    public bool timedout = false;

    public CommTimer()
    {
        timedout = false;
        tmrComm.AutoReset = false;
        tmrComm.Enabled = false;
        tmrComm.Interval = 1000; //default to 1 second
        tmrComm.Elapsed += new ElapsedEventHandler(OnTimedCommEvent);
    }

    public void OnTimedCommEvent(object source, ElapsedEventArgs e)
    {
        timedout = true;
        tmrComm.Stop();
    }

    public void Start(double timeoutperiod)
    {
        tmrComm.Interval = timeoutperiod; //time to time out in milliseconds
        tmrComm.Stop();
        timedout = false;
        tmrComm.Start();
    }
}