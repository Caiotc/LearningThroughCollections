using System;
using System.Collections.Generic;
using System.Linq;

namespace ListasObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando Classes";
            string aulaSets = "Trabalhando com Conjuntos";

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            // aulas.ForEach(aula => { Console.WriteLine(aukla); });
            //Console.WriteLine("Acessando por index " + aulas[0]);
            //Console.WriteLine("Usando .first "+ aulas.First());
            //Console.WriteLine("Usando .last " + aulas.Last());
            aulas[0] = "trabalhando com listas";
            aulas.ForEach(aula => { Console.WriteLine(aula); });
            Console.WriteLine("A primeira ocorrência! No caso 'trabalhando' é: " + aulas.First(e => e.Contains("trabalhando")));
            Console.WriteLine("" + aulas.FirstOrDefault(e => e.Contains("conjuntos")));
            Console.ReadLine();
        }
    }
}
