namespace PomadoroTimer.Model
{
  public class Todo
  {
    private TodoStopwatch stopwatch;

    public string Title;

    public string Duration;

    public Todo(string title) 
    {
      this.stopwatch = new TodoStopwatch();
      this.Title = title;
    }

    public void StartWatch()
    {
      stopwatch.Start();
    }

    public void PauseWatch()
    {
      stopwatch.Pause();
      this.UpdateDuration();
    }

    public void StopWatch()
    {
      stopwatch.Stop();
      this.UpdateDuration();
    }

    public void UpdateDuration()
    {
      var duration = stopwatch.GetDuration();
      this.Duration = String.Format("{0:00}:{1:00}", duration.Hours, duration.Minutes);
    }
  }
}
