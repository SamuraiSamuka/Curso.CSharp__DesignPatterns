using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Investimentos
{
    public class Conservador : Investimento
    {
        public double Aplica(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
