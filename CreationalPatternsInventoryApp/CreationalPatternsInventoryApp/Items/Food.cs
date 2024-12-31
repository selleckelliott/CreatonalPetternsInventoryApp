using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Items
{
  public class Food : IItem
  {
    public string Name { get; private set; }

    public Food(string name)
    {
      Name = name;
    }
    public void DisplayInfo()
    {
      Console.WriteLine($"Food Item: {Name}");
    }
    public IItem Clone()
    {
      return new Food(Name);
    }
  }
}
