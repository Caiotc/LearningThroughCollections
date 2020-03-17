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
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando em conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            //aulas.Add("Conclusão")
            //Somente objetos que herdão a calsse Aula
            Imprimir(aulas);
            aulas.Sort();
            Imprimir(aulas);
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> list)
        {
            Console.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class Aula : IComparable
    {
        //Aula herda de object
        //O toString é o de Object namespace.NomeDaClasse

        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public int Tempo { get => this.tempo; set => this.tempo = value; }
        public String Titulo { get => this.titulo; set => this.titulo = value; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            return $"[título {this.titulo}, tempo: {this.tempo} minutos]";
        }
    }
}