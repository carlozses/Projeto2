using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projeto
{
    public class CCorrente
    {
        public bool especial;
        public CCorrente(string numero, double limite) : this()
        {
            this.limite = limite;
            this.numero = numero;
        }
        public CCorrente() : base()
        {

        }

    }
}