using System;
using System.Collections.Generic;

namespace programaBancario
{
    public class Banco
    {
        List<Conta> contas = new List<Conta>();

        public void CriarConta()
        {
         Console.WriteLine();
         Console.WriteLine("Digite nome: ");

         String nome = Console.ReadLine();

         Console.WriteLine();
         Console.WriteLine("Digite saldo: ");
         
         double saldo = int.Parse(Console.ReadLine());

         Console.WriteLine();
         Console.WriteLine("Digite crédito: ");

         double credito = int.Parse(Console.ReadLine());

         Console.WriteLine();
         Console.WriteLine("Digite 0 para conta pessoal ou 1 para conta juridica: ");

         TipoConta tipoConta = (TipoConta)int.Parse(Console.ReadLine());

         Conta novaConta = new Conta(nome, saldo, credito, tipoConta);
         contas.Add(novaConta);

        }

        public void SacarDinheiroDeConta()
        {
         Console.WriteLine();
         Console.WriteLine("Digite numero da conta: ");
         
         int indexConta = int.Parse(Console.ReadLine());
         if(indexConta >= contas.Count || indexConta < 0){
             Console.WriteLine("Valor invalido, cancelando operação");
             Console.WriteLine();

             return;
         }

         Console.WriteLine();
         Console.WriteLine("Digite valor de saque: ");

         double saque = int.Parse(Console.ReadLine());

         contas[indexConta].SacarSaldo(saque);

        }

        public void DepositarDinheiroDeConta()
        {
         Console.WriteLine();
         Console.WriteLine("Digite numero da conta: ");
         
         int indexConta = int.Parse(Console.ReadLine());
         if(indexConta >= contas.Count || indexConta < 0){
            Console.WriteLine("Valor invalido, cancelando operação");
            Console.WriteLine();

            return;
         }

         Console.WriteLine();
         Console.WriteLine("Digite valor de deposito: ");

         double deposito = int.Parse(Console.ReadLine());

         contas[indexConta].DepositarSaldo(deposito);

        }

        public void TransferirDinheiroDeConta()
        {
         Console.WriteLine();
         Console.WriteLine("Digite numero da conta: ");
         
         int indexConta = int.Parse(Console.ReadLine());
         if(indexConta >= contas.Count || indexConta < 0){
            Console.WriteLine("Valor invalido, cancelando operação");
            return;
         }

         Console.WriteLine();
         Console.WriteLine("Digite numero da conta a receber valor: ");
         
         int indexContaAtiva = int.Parse(Console.ReadLine());
         if(indexContaAtiva >= contas.Count || indexContaAtiva < 0){
            Console.WriteLine("Valor invalido, cancelando operação");
            return;
         }

         Console.WriteLine();
         Console.WriteLine("Digite valor de deposito: ");

         double deposito = int.Parse(Console.ReadLine());

         contas[indexConta].TransferirSaldo(deposito, contas[indexContaAtiva]);

        }

        public void ListarTodasAsContas()
        {
            if(contas.Count <= 0){
                Console.WriteLine("Não há contas.");
                Console.WriteLine();
                return;
            }
           for(int i = 0; i < contas.Count; i++)
           {
            Console.WriteLine($"#{i} " + contas[i].ToString());
           }
        }
    }
}