using LearningThroughCollections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListaSomenteLeitura
{
    class Curso
    {
		private IList<Aula> aulas;
		private string instrutor;
		private string nome;

		public Curso(string instrutor, string nome)
		{
			this.instrutor = instrutor;
			this.nome = nome;
			this.aulas = new List<Aula>();
		}

		internal void Adiciona(Aula aula)
		{
			this.aulas.Add(aula);
		}

		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas); }
			
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string Instrutor 
		{
			get { return instrutor; }
			set { instrutor = value; }
		}


	}
}
