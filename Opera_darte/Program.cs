using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opera_darte
{
    public class Program
    {

        static void Main(string[] args)
        {
            Quadro b = new Quadro("Leo", 100, 100, 2000, 25);
            Quadro q = new Quadro("Picasso",150,169,100,50);

            Console.WriteLine(q.ToString() + " PREZZO FINALE " + q.Prezzofin() + " ULTIMA OFFERTA " + q.Ultimaoff());

            q.ModDati(69, 69, 45, 20);

            Console.WriteLine(q.ToString() + " PREZZO FINALE " + q.Prezzofin() + " ULTIMA OFFERTA " + q.Ultimaoff());

            q.Offerta(1000);

            Console.WriteLine(q.ToString() + " PREZZO FINALE " + q.Prezzofin() + " ULTIMA OFFERTA " + q.Ultimaoff());

            Console.WriteLine(q.Confronta(q,b));

        }
    }
}
