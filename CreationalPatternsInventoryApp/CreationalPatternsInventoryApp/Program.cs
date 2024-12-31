using CreationalPatternsInventoryApp.Factories;
using CreationalPatternsInventoryApp.Items;
using CreationalPatternsInventoryApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
  static void Main()
  {
    IItemFactory foodFactory = new FoodFactory();
    IItemFactory electronicsFactory = new ElectronicsFactory();
    IItemFactory furnitureFactory = new FurnitureFactory();

    IItem apple = foodFactory.CreateItem("Apple");
    IItem laptop = electronicsFactory.CreateItem("Laptop");
    IItem sofa = furnitureFactory.CreateItem("Sofa");

    Console.WriteLine("Created Items:");
    apple.DisplayInfo();
    laptop.DisplayInfo();
    sofa.DisplayInfo();
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Cloning Items:");
    IItem clonedApple = apple.Clone();
    IItem clonedLaptop = laptop.Clone();
    IItem clonedSofa = sofa.Clone();

    clonedApple.DisplayInfo();
    clonedLaptop.DisplayInfo();
    clonedSofa.DisplayInfo();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Activity Log:");
    Logger.Instance.DisplayLogs();
  }
}