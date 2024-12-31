﻿using CreationalPatternsInventoryApp.Items;
using CreationalPatternsInventoryApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatternsInventoryApp.Factories
{
  public class FoodFactory : IItemFactory
  {
    public IItem CreateItem(string name)
    {
      Logger.Instance.Log($"Food item created: {name}");
      return new Food(name);
    }
  }
}
