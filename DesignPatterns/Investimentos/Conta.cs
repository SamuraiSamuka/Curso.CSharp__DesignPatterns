using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            Saldo += valor;
        }
        public Conta(double saldo)
        { Saldo = saldo; }
    }
}
