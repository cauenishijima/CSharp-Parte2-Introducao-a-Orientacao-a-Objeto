using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoCaue = new ContaCorrente();

            contaDoCaue.titular = "Cauê Nishijima";
            contaDoCaue.agencia = 3095;
            contaDoCaue.numero = 084426;
            contaDoCaue.saldo = 5000;

            Console.WriteLine("Titular: " + contaDoCaue.titular);
            Console.WriteLine("Agência: " + contaDoCaue.agencia);
            Console.WriteLine("Número: " + contaDoCaue.numero);
            Console.WriteLine("Saldo: " + contaDoCaue.saldo);

            contaDoCaue.saldo += 200;
            Console.WriteLine("Saldo: " + contaDoCaue.saldo);

            Console.ReadLine();
        }
    }
}
