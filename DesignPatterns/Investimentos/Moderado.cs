using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Investimentos
{
    public class Moderado : Investimento
    {
        public double Aplica(Conta conta)
        {
            bool sorte = new Random().Next(101) > 50;

            if (sorte)
            {
                return conta.Saldo * 0.025;
            }
            else
            {
                return conta.Saldo * 0.007;
            }
        }
    }
}
