using CreationalPatternsInventoryApp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Factories
{
  public interface IItemFactory
  {
    IItem CreateItem(string name);
  }
}
