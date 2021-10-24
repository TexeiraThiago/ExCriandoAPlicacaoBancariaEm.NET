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
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
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

        private static void Transferir()
        {
            System.Console.Write("Digite o número da conta de Origem: ");
            int contaOrigem = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o número da conta de Destino");
            int contaDestino = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor que deseja transferir: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[contaDestino].Transferir(valorTransferencia, listContas[contaDestino]);
        }

        private static void Depositar()
        {
            System.Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o valor que deseja Depositar: ");
            double entradaValor = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(entradaValor);
        }

        private static void Sacar()
        {
            System.Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o valor que deseja sacar: ");
            double entradaValor = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(entradaValor);
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
            System.Console.Write("Insira uma nova Conta: ");

            System.Console.Write("Digite 1 para Pessoa Física e 2 pata Pessoa Jurídica: ");
            int entrada = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            System.Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            System.Console.Write("Digite o Crédito Inicial: ");
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
            Console.WriteLine(" ");

            string Opcao = Console.ReadLine().ToUpper();
            return Opcao;
        }
    }
}
