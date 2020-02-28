using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio00_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("XXXXXXX Programa Conta Bancaria XXXXXXXXX");
            Console.WriteLine("---------------------------------------");

            Conta conta = new Conta();
       
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Conta bancaria");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Numero Conta: ");
            conta.NumeroConta =int.Parse(Console.ReadLine());

            Console.Write("Cadastro Nome Titular: ");
            conta.ClienteNome= Console.ReadLine();

            Console.Write("Cadastro CPF: ");
            conta.CPF= Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Conta com Deposito Inicial: ");
            conta.CD =char.Parse(Console.ReadLine());

            if (conta.CD == 'S')
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Valor do Deposito Inicial: ");
                conta.DepositoInicial = double.Parse(Console.ReadLine());

                conta.SaldoInicial();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.Write("-----------Dados da Conta---------------");


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine(conta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Valor do Deposito: ");
                conta.Deposito = double.Parse(Console.ReadLine());

                conta.SaldoAtualizado();

                Console.WriteLine(conta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

              
                Console.Write("Valor do Saque: ");
                conta.Saque = double.Parse(Console.ReadLine());

                conta.SSaque();

                Console.WriteLine(conta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");



                Console.ReadKey();

            }
            else
            {

                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("-----------Dados da Conta---------------");


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine(conta);


                Console.WriteLine("------------------------------------");


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Valor do Deposito: ");
                conta.Deposito = double.Parse(Console.ReadLine());

                conta.SaldoAtualizado();

                Console.WriteLine(conta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Valor do Saque: ");
                conta.Saque = double.Parse(Console.ReadLine());

                conta.SSaque();

                Console.WriteLine(conta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");





                Console.ReadKey();
            }
        }
    }
}
