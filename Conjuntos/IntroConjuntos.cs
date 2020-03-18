using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class IntroConjuntos
    {
        private static void Main(string[] args)
        {
            //Sets == COnjunto
            //Conjuntos
            //1. Não permite duplicidade
            //2. os elementos não são mantido em ordem específica
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //adicionando no conjunto
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimindo 
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",",alunos));
            //Qual a diferença  para uma lista?

            //adicionando mais 3
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine( string.Join(",",alunos));
            //Removendo e adicionando um 
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",",alunos));
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",",alunos));
            //vantagem de velocidade de busca! comparado com lista
            //hash set custa mais memoria
            //ISet nãi tem implementado o sort
            // alunos.Sort();

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",", alunosEmLista));
        }
    }
}
