using System.Diagnostics;

namespace PomadoroTimer.Model
{
  public class TodoStopwatch 
  {
    private readonly Stopwatch stopwatch;

    private TimeSpan duration;

    private DateTime endDate;

    public readonly DateTime StartDate;

    public TodoStopwatch() 
    {
      this.StartDate = DateTime.Now.ToLocalTime();
      this.stopwatch = new Stopwatch();
    }

    public void Start()
    {
      this.stopwatch.Start();
    }

    public void Pause()
    {
      this.stopwatch.Stop();
      this.duration += stopwatch.Elapsed;
    }

    public void Stop()
    {
      this.stopwatch.Stop();
      this.endDate = DateTime.Now.ToLocalTime();
    }

    public TimeSpan GetDuration()
    {
      return this.duration;
    }
  }
}
