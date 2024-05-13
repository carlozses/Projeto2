using Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class CPoupanca
    {
        public CPoupanca() : base(){
            
        }
        public CPoupanca(string numero) : this()
        {
            this.limite = 0;
            this.numero = numero;
        }
    }
}
