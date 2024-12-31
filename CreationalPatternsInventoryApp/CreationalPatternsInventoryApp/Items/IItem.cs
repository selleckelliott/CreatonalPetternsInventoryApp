using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Items
{
  public interface IItem
  {
    string Name { get; }
    void DisplayInfo();
    IItem Clone();
  }
}
