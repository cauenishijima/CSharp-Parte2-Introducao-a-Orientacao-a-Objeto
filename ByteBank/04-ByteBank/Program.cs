using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);

            bool resultaSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultaSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDoLuiz = new ContaCorrente();

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta do Luiz: " + contaDoLuiz.saldo);

            contaDoBruno.Transferir(200, contaDoLuiz);

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta do Luiz: " + contaDoLuiz.saldo);

            Console.ReadLine();
        }
    }
}
