using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>
            {
            new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
            new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
            new Pessoa{Nome="Vitor",DataNascimento=new DateTime(2002,1,10), Casada=false},
            new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
            };

            var linq1 =
                from p in pessoas
                where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                select p;



            var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));


            //1. Construa uma consulta que retorne as pessoas agrupadas em casadas e solteiras e também o número de
            //pessoas casadas e solteiras.
            // List<Pessoa> casadas = new List<Pessoa>;
            // List<Pessoa> solteiras = new List<Pessoa>;
            var resultado =
            from p in pessoas
            group p.Nome by p.Casada into grupoPessoas
            select new
            {
                Categoria = grupoPessoas.Key ,
                Pessoas = grupoPessoas.ToList(),
                quantidade = grupoPessoas.Count()
            };

            foreach (var pessoa in resultado)
            {
                Console.WriteLine(pessoa);
                foreach (var x in pessoa.Pessoas)
                {
                    Console.WriteLine(x);

                }
            }  

            // var older = pessoas.OrderBy((pessoa)=>pessoa.DataNascimento).First();
            // var young = pessoas.Where(p => !p.Casada).OrderBy((pessoa)=>pessoa.DataNascimento).Last();

            // Console.WriteLine(young);
        }
    }
}
