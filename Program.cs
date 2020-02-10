using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningThroughCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando Classes";
            string aulaSets = "Trabalhando com Conjuntos";
            //string[] aulas = new string[]
            //{
             //   aulaIntro,
               // aulaModelando,
                //aulaModelando
            //};
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;
            Console.WriteLine(aulas);
            //foreach (var item in aulas)
            //{
            //   Console.WriteLine(item);
            //}
            Console.WriteLine("A aula Modelnado esta no index " + Array.IndexOf(aulas,aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas,aulaModelando));
            Array.Reverse(aulas);
            printArray(aulas);
            Array.Resize(ref aulas, 2);
            printArray(aulas);
            Array.Resize(ref aulas, 3);
            printArray(aulas);
            Console.WriteLine(aulas.Length);
            aulas[aulas.Length - 1] = "conclusão";
            Array.Sort(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            printArray(copia);

            string[] clone = aulas.Clone() as string[];
            printArray(clone);
            Array.Clear(clone, 1, 2);
            printArray(clone);
            Console.ReadLine();

            
        }
        private static void printArray(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
