using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta.Models
{
    public class Cliente
    {
        private string _email;
        private string _nome;
        private string _cpf;
        private int _anoNascimento;

        public Cliente(string email, int anoNascimento, string nome, string cpf)
        {
            Email = email;
            AnoNascimento = anoNascimento;
            Nome = nome;
            CPF = cpf;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int AnoNascimento
        {
            get => _anoNascimento;
            set
            {
                if ((DateTime.Now.Year - value) >= 18)
                {
                    _anoNascimento = value;
                }
                else
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }
            }
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string CPF
        {
            get => _cpf;
            set
            {
                if (value.Length == 11 && long.TryParse(value, out _))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("CPF deve conter 11 dígitos.");
                }
            }
        }



        public int Idade
        {
            get { return DateTime.Now.Year - AnoNascimento; }
        }


    }
}
