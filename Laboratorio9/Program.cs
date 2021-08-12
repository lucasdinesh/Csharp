using System;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa o termometro e mostra seu valor
            TermometroLimite term = new TermometroLimite(8);
            Console.WriteLine(term.ToString());
            // adiciona um tratador ao evento LimiteSuperiorEvent
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            // aumentar a temperatura além do limite
            term.Aumentar(6);
            Console.WriteLine(term.ToString());

        }

        private static void TrataLimiteSuperior(string msg)
        {
            Console.WriteLine(msg);
        }
    }

}
