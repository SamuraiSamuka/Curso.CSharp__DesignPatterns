using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Impostos
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 0)
            {
                if (orcamento.Valor < 1000)
                {
                    return orcamento.Valor * 0.05;
                }
                else if (orcamento.Valor <= 3000)
                {
                    return orcamento.Valor * 0.07;
                }
                else
                {
                    return orcamento.Valor * 0.08 + 30;
                }
            }
            else
            {
                Console.WriteLine("O orçamento não pode ser negativo");
                return -1;
            }
        }
    }
}