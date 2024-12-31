using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Utilities
{
  public class Logger
  {
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
    private List<string> _logs = new List<string>();

    private Logger() { }
    public static Logger Instance => _instance.Value;

    public void Log(string message)
    {
      _logs.Add($"[{DateTime.Now}] {message}");
    }
    public void DisplayLogs()
    {
      foreach (var log in _logs)
      {
        Console.WriteLine(log);
      }
    }
  }
}
