using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("wat type? (1:pic 2:kg 3:leave): ");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    FruitPics pic = new FruitPics();
                    pic.FruitA();
                }
                else if (choose == 2)
                {
                    FruitKG kg = new FruitKG();
                    kg.FruitA();
                }
                else
                {
                    break;
                }
                Console.WriteLine("you must pay " + Fruit.Price);
                Console.ReadLine();
            }
        }
    }
}
