using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente christiane = new Cliente();
            christiane.nome = "Christiane";
            christiane.cpf = "229.984.398-10";
            christiane.profissao = "Biomédica";

            ContaCorrente contaChristiane = new ContaCorrente();
            contaChristiane.titular = christiane;
            contaChristiane.agencia = 3095;
            contaChristiane.numero = 084426;
            contaChristiane.saldo = 1000.50;

            contaChristiane.titular.nome = "Christiane Chaves Oliveira";

            Console.WriteLine(christiane.nome);
            Console.WriteLine(contaChristiane.titular.nome);

            Console.ReadLine();
        }
    }
}
