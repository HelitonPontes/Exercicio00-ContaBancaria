using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio00_ContaBancaria
{
    class Conta
    {
        public string ClienteNome { get; set; }
        public int NumeroConta { get; set; }
        public string CPF { get; set; }
        public char CD = 'S';
        public double DepositoInicial { get; set; }
        public double Deposito { get; set; }
        public double Saldo { get; set; }
        public double Saque { get; set; }
        public double Taxa = 10;

        public Conta()
        {

        }

        public Conta(string clienteNome, int numeroConta, string cPF, double depositoInicial)
        {
            ClienteNome = clienteNome;
            NumeroConta = numeroConta;
            CPF = cPF;
            DepositoInicial = depositoInicial;
        }

        public Conta(string clienteNome, int numeroConta, string cPF, double depositoInicial, double deposito) : this(clienteNome, numeroConta, cPF, depositoInicial)
        {
            Deposito = deposito;
        }

        public Conta(string clienteNome, int numeroConta, string cPF, double depositoInicial, double deposito, double saque, double taxa) : this(clienteNome, numeroConta, cPF, depositoInicial, deposito)
        {
            Saque = saque;
            Taxa = taxa;
        }

        public Conta(string clienteNome, int numeroConta, string cPF, char cD, double depositoInicial, double deposito, double saldo, double saque, double taxa)
        {
            ClienteNome = clienteNome;
            NumeroConta = numeroConta;
            CPF = cPF;
            CD = cD;
            DepositoInicial = depositoInicial;
            Deposito = deposito;
            Saldo = saldo;
            Saque = saque;
            Taxa = taxa;
        }

        public override string ToString()
        {
            return "Numero Conta: " + NumeroConta + " Nome Titular: " + ClienteNome
                + " CPF Cliente: "+CPF +"\n Deposito Inicial" + CD + "  XXX Saldo Conta: "
                + Saldo;
        }

        public void SaldoInicial()
        {
            Saldo = DepositoInicial;
        }

        public void SaldoAtualizado()
        {
            Saldo = Saldo + Deposito;
        }
        public void SSaque()
        {
            Saldo = Saldo -(Saque+Taxa);
        }
    }
}
