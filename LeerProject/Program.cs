using System;
using System.Reflection.Metadata;

namespace LeerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string readline = Console.ReadLine();
            string tekst = Console.ReadLine();
            string alles = readline + tekst;
            Console.WriteLine(alles);
        }
    }
}