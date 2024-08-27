using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _NET_STUDY.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string nome 
        {   get
            {
                return _nome.ToUpper();
            }


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public int idade
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                } 
                _idade = value;

            }
        }

        public void Apresentar (){

            Console.WriteLine ($"Nome: {nome}, Idade: {idade}");
        }
    }
}