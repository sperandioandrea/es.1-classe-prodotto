using es._1_classe_prodotto.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace es._1_classe_prodotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm = "pane";
            int pr = 2;
            prodotto p = new prodotto(nm, pr);
            prodotto n = new prodotto(nm, pr);
            Console.WriteLine(p.Nome());
            Console.WriteLine(n.Prezzo());
        }
    }
}
