using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;
using DesignPatterns.Impostos;
using DesignPatterns.Investimentos;

namespace DesignPatterns
{
    public class Strategy
    {
        public void Investimento(double valorInicial = 1000)
        {
            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            Orcamento orcamento = new Orcamento(valorInicial);
            Conta conta = new Conta(1000);

            double investA = conservador.Aplica(conta);
            double investB = moderado.Aplica(conta);
            double investC = arrojado.Aplica(conta);

            Console.WriteLine(investA);
            Console.WriteLine(investB);
            Console.WriteLine(investC);

            Console.ReadKey();
        }

        public void Imposto(double valorInicial = 1000)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();


            Orcamento orcamento = new Orcamento(valorInicial);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();


            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);


            Console.ReadKey();
        }
    }
}
