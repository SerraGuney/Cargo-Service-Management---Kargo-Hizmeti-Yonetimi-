using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static double shippingWeight;
        static string result;
        static List<string> list3 = new List<string>();
        static List<double> list2 = new List<double>();
        static Dictionary<int, string> addresses = new Dictionary<int, string>();
        static List<int> list = new List<int>();
        static int cargoAmount()
        {          
            Console.WriteLine("You can enter a maximum of 2 cargos.");
            Console.Write("Enter your shipping amount :");
            int amount2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amount2; i++)
            {
                Console.Write("cargo weight:");
                shippingWeight = Convert.ToDouble(Console.ReadLine());
                list2.Add(shippingWeight);
            }
            return 1;           
        }

        static string adressAmount()
        {
            addresses[35] = "İzmir";
            addresses[34] = "İstanbul";         
            Console.Write("how many cargo will you enter:");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can choose a maximum of 2 city license plates 34(İstanbul),35(İzmir)");
            for (int i = 0; i < amount; i++)
            {
                Console.Write("enter city license plate:");
              int  choice = Convert.ToInt32(Console.ReadLine());
                list.Add(choice);
            }
            foreach (var a in list)
            {
                result = addresses[a];
                list3.Add(result);
                Console.WriteLine(a + " " + "city license plate:" + result+ " " + "adress");
            }
            return "result1";
        }

        static void Main(string[] args)
        {
            
            Console.Write("Please enter the cargo volume, price is not included:");
            double volume = Convert.ToDouble(Console.ReadLine());
            
            Packet packet1 = new Packet(cargoAmount(), volume, adressAmount());
            foreach (var a in list3)
            {
                foreach (var b in list2)
                {
                    if (a=="İstanbul")
                    {
                        Console.WriteLine(Packet.totalBill(b, a));
                    }

                    else if ( a == "İzmir")
                    {
                        Console.WriteLine(Packet.totalBill(b, a));
                    }
                }               
            }
            Console.ReadLine();
        }
    }
}

