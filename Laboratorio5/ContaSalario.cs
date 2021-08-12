using System;

namespace Laboratorio5
{
    public class ContaSalario : Conta
    {

        public static decimal MAX_VALOR_SALDO = 10500.20M;
        public static int MAX_QTD_SAQUES = 2;
        private int qtdSaquesMes;
        public ContaSalario(string t) : base(t)
        {
            qtdSaquesMes = 0;
        }

        public override string Id
        {
            get { return this.Titular + "(CS)"; }
        }

        public override void Depositar(decimal valor)
        {
            if (Saldo + valor <= MAX_VALOR_SALDO)
            {
                base.Depositar(valor);

            }
            else
            {
                Console.WriteLine("Valor maximo excedido");
            }
        }

        public override void Sacar(decimal valor)
        {   
            if(qtdSaquesMes < MAX_QTD_SAQUES)
            {
                base.Sacar(valor);
                qtdSaquesMes ++;

            }
            else 
            {
                Console.WriteLine("Quantidade de saques maximos excedidos");
            }
            
        }

    }
}