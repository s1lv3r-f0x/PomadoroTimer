using System;
using System.Timers;

namespace PomadoroTimer.Model
{
  public class Tracker
  {
    public string Note { get; set; }

    private System.Timers.Timer timer;

    public Tracker() 
    {
      this.timer = new System.Timers.Timer();
    }

    public void StartTimer() 
    {
      this.timer.Start();
    }

    public string StopTimer() 
    {
      this.timer.Stop();
      return timer.Interval.ToString();
    }
  }
}
