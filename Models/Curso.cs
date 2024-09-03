using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)//Parametro: Recebe uma pessoa
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;

        }
        public void RemoveAluno(Pessoa aluno)//OU pode usar bool e colocar "Return" antes de "Aluno..."
        {

            Alunos.Remove(aluno);
        }
        public void ListarAluno()
        {
            //int cont = 0;
            Console.WriteLine($"Alunos do curso de {Nome}");
            for(int i = 0; i < Alunos.Count; i++)
            {
                //concatenando
                //string texto = "Nº " + (i+1) + " - " + Alunos[i].NomeCompleto;
                //Interploração
                string texto = $"Nº {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
           
        }
    }
}

/*
 foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
                //cont++;
            }
*/