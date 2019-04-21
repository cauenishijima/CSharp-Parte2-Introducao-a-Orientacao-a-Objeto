using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraConta = new ContaCorrente();
            primeiraConta.titular = "Cauê";
            primeiraConta.agencia = 3095;
            primeiraConta.numero =  084426;

            ContaCorrente segundaConta = new ContaCorrente();
            segundaConta.titular = "Cauê";
            segundaConta.agencia = 3095;
            segundaConta.numero = 084426;

            Console.WriteLine("Comparaação de tipo referência: " + (primeiraConta == segundaConta));

            int num1 = 27;
            int num2 = 27;

            Console.WriteLine("Comparação de tipo valor: " + (num1 == num2));

            segundaConta = primeiraConta;

            Console.WriteLine(primeiraConta == segundaConta);

            primeiraConta.saldo = 300;
            Console.WriteLine("Saldo conta 1: " + primeiraConta.saldo);
            Console.WriteLine("Saldo conta 2: " + segundaConta.saldo);



            Console.ReadLine();

        }
    }
}
