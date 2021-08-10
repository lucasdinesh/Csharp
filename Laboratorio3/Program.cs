using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
        ContaCorrente minhaConta = new ContaCorrente(340, "Lucas", DateTime.Now);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine(minhaConta.Saldo);    
        Console.WriteLine(minhaConta.Titular);    
        Console.WriteLine(minhaConta.Data);
        minhaConta.Saldomedio();   
        }
    }
}
