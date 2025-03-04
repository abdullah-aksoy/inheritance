using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Classes
{
    public class Araba
    {
        public void duzVites(string carName)
        {
            Console.WriteLine(carName+ " -> Düz viteslidir.");


        }
        public void otomatikVites(string carName)
        {
            Console.WriteLine(carName + " -> Otomatik viteslidir.");
        }
    }
}
