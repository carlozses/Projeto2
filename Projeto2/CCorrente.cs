using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projeto
{
    public class CCorrente : Conta
    {
        private bool especial;
        public bool Especial
        {
            get => this.especial; 
            set=> this.especial = value;
        }
        public CCorrente(string numero, double limite) : base(numero)
        {
            this.limite = limite;
        }
        public CCorrente() : base() {}
    }
}