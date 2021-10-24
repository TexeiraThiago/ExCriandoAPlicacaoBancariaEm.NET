using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoDoUsuario = ObterOpcaoUsuario();
            while (opcaoDoUsuario != "X")
            {
                switch (opcaoDoUsuario)
                {
                    case "1":
                        ListarConta();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "4":
                        // Sacar();
                        break;
                    case "5":
                        // Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoDoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por obter nosso serviço o desenvolvedor Agradece!");
            Console.ReadLine();
        }

        private static void ListarConta()
        {
            Console.WriteLine();
            if (listContas.Count == 0)
            {
                System.Console.WriteLine("Não há nenhuma conta cadastrada");
                return;
            }
            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                System.Console.Write("#{0} - ", i);
                System.Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            System.Console.WriteLine("Insira uma nova Conta");

            System.Console.WriteLine("Digite 1 para Pessoa Física e 2 pata Pessoa Jurídica");
            int entrada = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do Cliente");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Digite o Saldo Inicial:");
            double entradaSaldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Crédito Inicial:");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta
            (
                tipoConta: (TipoConta)entrada,
                saldo: entradaSaldo,
                credito: entradaCredito,
                nome: entradaNome
            );

            listContas.Add(novaConta);
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("App Bancário iniciado");
            Console.WriteLine("Digite sua opção");
            Console.WriteLine("1 - Litar Contas");
            Console.WriteLine("2 - Inserir nova Conta");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Saque");
            Console.WriteLine("5 - Depósito");
            Console.WriteLine("C - Limpar a tela");
            Console.WriteLine("X - Sair");

            string Opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return Opcao;
        }
    }
}
