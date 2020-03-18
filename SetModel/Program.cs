using LearningThroughCollections;
using ListaSomenteLeitura;
using System;

namespace SetModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas",21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula",20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
            //um aluno também tem matricula

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            //Imprimindo os alunos matriculados
            Console.WriteLine("Alunos Matriculados");

            foreach (var item in csharpColecoes.Alunos)
            {
                Console.WriteLine(item);
            }



        }
    }
}
