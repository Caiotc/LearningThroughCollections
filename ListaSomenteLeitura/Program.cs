using ListaSomenteLeitura;
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
            Curso csharColecoes = new Curso("C# Collections", "Marcelo Silva");
            csharColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharColecoes.Aulas);
        }

        private static void Imprimir(IList<Aula> list)
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
