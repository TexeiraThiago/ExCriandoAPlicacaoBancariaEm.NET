using System;

namespace DIO.Bank
{
    public class Conta
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            System.Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            System.Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);

            };
        }
        //Override serve para sobrescrever um método que já existe
        public override string ToString()
        {
            string retorno = $"TipoConta: {this.TipoConta}\nNome: {this.Nome}\nSaldo: {this.Saldo}\nCredito: {this.Credito}";
            return retorno;
        }

        public static string ObterOpcaoUsuari()
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