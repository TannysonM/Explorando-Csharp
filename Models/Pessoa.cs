using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string name, String sobrenome)
        {
            Name = name;
            Sobrenome = sobrenome;
        }
        private string _name;
        private int _idade;
        public string Name 
        { 
            get // get => _nome.ToUpper();///body expression
            {
                return _name.ToUpper();
            }
            
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode está vazio");
                }
                _name = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();
        public int Idade 
        {
             get => _idade;
             
             set
             {
                if(value < 0)
                {
                    throw new ArgumentException("Idade invalida!");
                }
                _idade = value;   
             } 
        }

        public void Apresentacao()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}