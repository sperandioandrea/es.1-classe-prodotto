using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._1_classe_prodotto.Properties
{
    //creazione classe prodotto
    public class prodotto
    {
        private string nome;
        private int prezzo;

        //costruttore parametri+
        public prodotto(string nome1, int prezzo1)
        {
            nome = nome1;
            prezzo= prezzo1;
        }

        //metodi che restituiscano il valore degli attributi
        public string Nome()
        {
            return nome;
        }
        public int Prezzo()
        {
            return prezzo;
        }
    } 
}
