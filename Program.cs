using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowCharCount
{
    // FAS 1. Uppgift 3 - Rad/tecken-räknare
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett filnamn: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Öppnar: {0}", fileName);
        }
    }
}
