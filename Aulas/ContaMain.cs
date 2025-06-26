// See https://aka.ms/new-console-template for more information                                                                                                                                                           
using System;
using System.Globalization;

namespace Estudo {
    class Program {
        static void Main(string[] args) {

            Conta conta = new Conta();
            Console.WriteLine("Entre o número da conta: ");
            conta.setNumeroConta(int.Parse(Console.ReadLine()));
            Console.WriteLine("Entre o titular da conta: ");
            conta.setTitular(Console.ReadLine());
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 's') {
                conta.deposito();
                Console.WriteLine(conta);
            }
            else if (escolha == 'n') {
                Console.WriteLine(conta);
            }
            else {
                Console.WriteLine("Resposta inválida");
                return;
            }

            Console.WriteLine("----OPÇÕES----");
            Console.WriteLine("1-Saque");
            Console.WriteLine("2-Depósito");
            Console.WriteLine("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                conta.saque();
                Console.WriteLine(conta);
            }
            else if (opcao == 2) {
                conta.deposito();
                Console.WriteLine(conta);
            }
            else {
                Console.WriteLine("Opção inválida");
            }
        }


    }
}


