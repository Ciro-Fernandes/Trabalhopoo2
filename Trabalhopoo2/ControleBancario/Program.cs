
using ControleConta.Models;

Cliente cliente1 = new Cliente("Carlos@outlook.com", 2001, "Carlos", "11122211122");
Cliente cliente2 = new Cliente("Jose@yahoo.com", 2002, "Jose", "22211122211");

Conta conta1 = new Conta(123456, 1235.42, cliente1);
Conta conta2 = new Conta(654321, 2341.42, cliente2);
Conta conta3 = new Conta(121212, cliente1);

ContaEspecial contaEspecial1 = new ContaEspecial(1111, cliente1, 100);
ContaCaixinha contacaixinha1 = new ContaCaixinha(111122, cliente1);

Console.WriteLine($"Cliente: {cliente1.Nome}, CPF: {cliente1.CPF}, Nascimento: {cliente1.Idade}");
Console.WriteLine($"Cliente: {cliente2.Nome}, CPF: {cliente2.CPF}, Nascimento: {cliente2.Idade}\n");

Console.WriteLine($"Saldo inicial da conta {conta1.Numero} é : R${conta1.Saldo}");
Console.WriteLine($"Saldo inicial da conta {conta2.Numero} é : R${conta2.Saldo}\n");

double saldoTotalinicial = conta1.Saldo + conta2.Saldo;
conta1.Transferir(conta2, 100);
conta1.Sacar(100);
double saldoTotalGeral = conta1.Saldo + conta2.Saldo;

Conta contaMaiorSaldo = (conta1.Saldo > conta2.Saldo) ? conta1 : conta2;

Console.WriteLine($"Saldo  inicial das duas contas: R${saldoTotalinicial}");
Console.WriteLine($"Conta com maior saldo: {contaMaiorSaldo.Numero}");
Console.WriteLine($"Saldo  geral das duas contas: R${saldoTotalGeral:C}");

contaEspecial1.Sacar(50);
Console.WriteLine($"Saldo depois de sacar dentro do limite na conta especial {contaEspecial1.Saldo}\n");

Console.WriteLine($"Saldo inicial da caixinha {contacaixinha1.Saldo:C}");
contacaixinha1.Depositar(50);
contacaixinha1.Sacar(10);
Console.WriteLine($"Saldo da conta {conta3} é {conta3.Saldo:C}");



