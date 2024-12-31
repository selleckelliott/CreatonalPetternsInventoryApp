using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Items
{
  public class Furniture : IItem
  {
    public string Name { get; private set; }
    public Furniture(string name)
    {
      Name = name;
    }
    public void DisplayInfo()
    {
      Console.WriteLine($"Furniture Item: {Name}");
    }
    public IItem Clone() => new Furniture(Name);
  }
}
