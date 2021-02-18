using System;

namespace programaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Banco banco = new Banco();
            string opcao = ObterOpcaoUsuario();

            while(opcao != "X")
            {
                LidarComInput(banco, opcao);
                opcao = ObterOpcaoUsuario();
            }

            
            Console.WriteLine("Obrigado por usar nossos serviços!");
            Console.WriteLine();

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine(" Banco CMD, Qual seu pedido?");
            Console.WriteLine(" 1 - Listar Contas");
            Console.WriteLine(" 2 - Criar Conta");
            Console.WriteLine(" 3 - Transferir Dinheiro");
            Console.WriteLine(" 4 - Sacar Dinheiro");
            Console.WriteLine(" 5 - Depositar Dinheiro");
            Console.WriteLine(" C - Limpar tela");
            Console.WriteLine(" X - Sair");
            Console.WriteLine();

            return Console.ReadLine();;
        }

        private static void LidarComInput(Banco banco, string input)
        {
            input.ToUpper();
            switch(input)
            {
                case "1":
                banco.ListarTodasAsContas();
                break;
                case "2":
                banco.CriarConta();
                break;
                case "3":
                banco.TransferirDinheiroDeConta();
                break;
                case "4":
                banco.SacarDinheiroDeConta();
                break;
                case "5":
                banco.DepositarDinheiroDeConta();
                break;
                case "C":
                Console.Clear();
                break;
                default:
                Console.WriteLine("Selecione um valor válido.");
                Console.WriteLine();
                break;
            }
        }
    }
}
