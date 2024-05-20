using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Conta
    {
        protected string numero;
        private double saldo;
        private bool status;
        protected double limite;
        protected List<Transacao> transacoes;
        public double Saldo
        {
            get => this.saldo;
        }
        public double Limite
        {
            get => this.limite;
            set
            {
                if (value >= 0)
                    this.limite = value;
            }
        }
        public string Numero
        {
            get => this.numero;
            set => this.numero = value;
        }
        public bool Status
        {
            get => this.status;
            set => this.status = value;
        }
        public List<Transacao> Transacoes{
            get => this.transacoes;
        }
        public Conta()
        {
            this.saldo = 0;
            this.status = true;
            transacoes = new List<Transacao>();
        }
        public Conta(string numero) : this()
        {
            this.numero = numero;
        }
        public bool Sacar(double valor)
        {
            if (status)
            {
                if (saldo - valor > -limite)
                {
                    saldo -= valor;
                    transacoes.Add(new Transacao(valor, 'S', this));
                    return true;
                }
            }
            return false;
        }
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                transacoes.Add(new Transacao(valor, 'D', this));
                return true;
            }
            return false;
        }

        public bool Transferir(Conta destino, double valor)
        {
            if (destino.status && Sacar(valor) && destino.Depositar(valor))
            {
                transacoes[transacoes.Count - 1].Duplicata = destino.transacoes[destino.transacoes.Count - 1];
                destino.transacoes[destino.transacoes.Count - 1].Duplicata = transacoes[transacoes.Count - 1];
                return true;
            }
            return false;
        }
    }
}
