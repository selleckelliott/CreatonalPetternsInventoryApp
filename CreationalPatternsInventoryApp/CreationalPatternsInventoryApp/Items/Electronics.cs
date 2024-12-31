using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Items
{
  public class Electronics : IItem
  {
    public string Name { get; private set; }
    public Electronics(string name)
    {
      Name = name;
    }
    public void DisplayInfo()
    {
      Console.WriteLine($"Electronics Item: {Name}");
    }
    public IItem Clone() => new Electronics(Name);
  }
}
