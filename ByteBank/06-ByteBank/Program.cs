using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Cauê";
            cliente.CPF = "229.984.398-10";
            cliente.Profissao = "Desenvolvedor C#";

            ContaCorrente conta = new ContaCorrente(867,867321);
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine("Titular: {0}", conta.Titular.Nome);
            Console.WriteLine("Agencia {0}, Conta {1}", conta.Agencia, conta.Numero);
            Console.WriteLine("O saldo da conta é {0}", conta.Saldo);
            Console.WriteLine("Total de Contas: {0}!", ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(867, 867123);
            Console.WriteLine("Total de Contas: {0}!", ContaCorrente.TotalDeContasCriadas);



            Console.ReadLine();

        }
    }
}
