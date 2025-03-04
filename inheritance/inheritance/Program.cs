using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance.Classes;

namespace inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            audi.otomatikVites("Audi");

            BMW bmw = new BMW();
            bmw.duzVites("BMW");

            Porsche porsche = new Porsche();
            porsche.otomatikVites("Porsche");

            Togg togg = new Togg();
            togg.otomatikVites("Togg");

            Toyota toyota= new Toyota();
            toyota.duzVites("Toyota");


        }
    }
}
