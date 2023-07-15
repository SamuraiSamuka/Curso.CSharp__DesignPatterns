using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Aplica(Conta conta)
        {
            long num = new Random().Next(101);
            string sorte = num > 80 ? "grande" : num > 50 ? "pequena" : "sem";

            if (sorte == "grande")
            {
                return conta.Saldo * 0.05;
            }
            else if (sorte == "pequena")
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
