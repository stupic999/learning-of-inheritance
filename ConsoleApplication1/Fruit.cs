using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fruit
    {
        public static double Price { get; set; }
        public virtual void FruitA()
        {
            return;
        }
    }

    class FruitPics : Fruit
    {
        public override void FruitA()
        {
            Console.WriteLine("how many pics?");
            int pics = int.Parse(Console.ReadLine());
            Console.WriteLine("how much each cost?");
            double cost = double.Parse(Console.ReadLine());
            Fruit.Price = (double)pics * cost;
        }
    }

    class FruitKG : Fruit
    {
        public override void FruitA()
        {
            Console.WriteLine("how much kg?");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("how much per kg cost?");
            double cost = double.Parse(Console.ReadLine());
            Fruit.Price = kg * cost;
        }
    }
}
