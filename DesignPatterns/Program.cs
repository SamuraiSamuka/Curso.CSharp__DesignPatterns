namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy = new Strategy();
            strategy.Investimento(2000);
            strategy.Imposto();
        }
    }
}