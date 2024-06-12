using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta.Models
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public override void Depositar(double valor)
        {
            if (valor <= 1)
            {
                Console.WriteLine("O valor do depósito deve ser maior que 1 real.");
            }
            if (valor > 0)
            {
                Saldo += valor + 1;
                Console.WriteLine($"Deposito realizado com sucesso. Saldo atual {Saldo}");
            }

        }

        public override bool Sacar(double valor)
        {
            if (Saldo - (valor + 5) >= 0)
            {
                Saldo -= valor + 5;
                Console.WriteLine($"Saque realizado com sucesso. Saldo atual {Saldo}");
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }
    }
}
