using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWCF.Olypics;
using ClientWCF.ServiceReference;

namespace ClientWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire il codice atleta");
            int codice = int.Parse(Console.ReadLine()); 

            OlympicsClient client = new OlympicsClient();
            Athlete result = client.GetAthlete(codice);

            Console.WriteLine(result.Name);

            Console.ReadLine();
        }
    }
}
