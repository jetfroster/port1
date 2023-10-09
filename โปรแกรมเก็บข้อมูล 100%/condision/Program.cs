using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace condision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Ponkrit Kampananurak ////
            Console.WriteLine("Please input in number for DATA!");
            int amount = int.Parse(Console.ReadLine());
            string[][] dataUser = new string[amount][];
            for(int i = 0; i < amount; i++)
            {
                dataUser[i] = new string[3];
            }
            Console.WriteLine(" ");


            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine(i+1 + "." + "Input your name.");
                dataUser[i][0] = Console.ReadLine();
                Console.WriteLine("Input your address.");
                dataUser[i][1] = Console.ReadLine();
                Console.WriteLine("Input your phone number.");
                dataUser[i][2] = Console.ReadLine();
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("===="+"summary"+"====");
            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("-----"+ (i+1) + "-----");
                Console.WriteLine("Name: " + dataUser[i][0]);
                Console.WriteLine("Addrees: " + dataUser[i][1]);
                Console.WriteLine("Phone number: " + dataUser[i][2]);
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
