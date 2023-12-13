using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Packet
    {
        private static double weight;
        private double volume;
        private static string address;
        
        public Packet(double a, double h, string ad)
        {
            weight = a;
            volume = h;
            address = ad;
        }

        public static int totalBill(int a, string ad)
        {
            int extraBill = 0;
            if (ad == "İzmir")
            {               
                extraBill = 10;                             
            }
            else if (ad == "İstanbul")
            {
                extraBill = 20;                
            }
            Console.WriteLine("Shipping cost:");
            return  a * 2 + extraBill;
        }
        public static double totalBill(double a, string ad)
        {
            int extraBill = 0;
            if (ad == "İzmir")
            {
                extraBill = 10; 
            }
            else if (ad == "İstanbul")
            {
                extraBill = 20; 
            }
            Console.WriteLine("Shipping cost:");
            return a * 2 + extraBill;
        }

    }
    
}

    





