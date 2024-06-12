using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta.Models
{

    public class ContaEspecial : Conta
    {
        private double _limite;
        public ContaEspecial(long numero, Cliente titular, double limite) : base(numero,titular)
        {
            _limite = limite;
        }
        public override bool Sacar(double valor)
        {
            if (Saldo + _limite - (valor + 0.10) >= 0)
            {
                Saldo -= valor + 0.10;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }

        public bool Transferir(Conta conta, double valor)
        {
            if (Saldo + _limite - valor >= 0)
            {
                Saldo -= valor;
                conta.Depositar(valor);

                Console.WriteLine($"Transferência realizada com sucesso.");
                Console.WriteLine($"Saldo da conta destino: {conta.Saldo:C}");
                Console.WriteLine($"Saldo da conta atual: {Saldo:C}");
                return true;
            }
            else
            {
                throw new ArgumentException("Saldo insuficiente para transferência");
            }
        }
    }
}
