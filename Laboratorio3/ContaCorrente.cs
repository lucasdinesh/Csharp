using System;

namespace Laboratorio3
{
    public class ContaCorrente
    {
        private decimal saldo;
        private DateTime data_criacao;
        private decimal acumulador;

        private int operacoes;
        private string titular;
        public const decimal MINIMO_DEPOSITO = 100;

        public void Depositar(decimal valor)
        {
            if (valor >= MINIMO_DEPOSITO)
            {
                saldo+= valor;
                acumulador += valor;
                operacoes++;
            }

            
        }

        public void Sacar(decimal valor)
        {
            saldo-=valor;
            acumulador -= valor;
            operacoes++;
        }

        public ContaCorrente(decimal val, string nome_titular,DateTime date)
        {
            saldo = val;
            titular = nome_titular;
            data_criacao = date;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }   

        public DateTime Data 
        {
            get { return data_criacao; }
        }

        public string Titular
        {
            get{return titular;}
        }  

        public void Saldomedio(){
            Console.WriteLine(acumulador/operacoes);
        } 

    }

}