﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSomenteLeitura
{
    public class Aluno
    {
		private string nome;
		private int numeroMatricula;

		public Aluno(string nome, int numeroMatricula)
		{
			this.nome = nome;
			this.numeroMatricula = numeroMatricula;
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


		public int NumeroMatricula
		{
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}
		public override string ToString()
		{
			return $"[Nome: {nome}, Matricula: {numeroMatricula}]";
		}
		public override bool Equals(object obj)
		{
			Aluno outro = obj as Aluno;

			if (outro == null)
			{
				return false;
			}

			return this.nome.Equals(outro.nome);
		}
		//Velocidade da busca de conjuntos depende do codigo de dispersão
		public override int GetHashCode()
		{
			return this.nome.GetHashCode();
		}
		//Dois objetos que são iguais possuem o mesmo hash code, mas o contrario não
	}
}
