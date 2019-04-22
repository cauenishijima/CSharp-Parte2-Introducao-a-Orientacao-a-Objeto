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

            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine("Titular: {0}", conta.Titular.Nome);
            Console.WriteLine("O saldo da conta é {0}", conta.Saldo);


            Console.ReadLine();

        }
    }
}
