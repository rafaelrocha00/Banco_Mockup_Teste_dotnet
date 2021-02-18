using System;
using System.Text;

namespace programaBancario
{
    public class Conta
    {
        string nome {get; set; }
        double saldo {get; set;}
        double credito {get; set;}
        TipoConta tipoConta {get; set; }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
            this.tipoConta = tipoConta;
        }

        public bool SacarSaldo(double valorSaque)
        {
            if(saldo - valorSaque < -credito)
            {
              Console.WriteLine("Saldo insuficiente");
              return false;
            }

            saldo -= valorSaque;
            MostrarSaldo();
            return true;
        }

        public void DepositarSaldo(double valorDeposito)
        {
            saldo += valorDeposito;
            MostrarSaldo();
        }

        public void MostrarSaldo()
        {
           Console.WriteLine($"Saldo atual da conta {nome} é {saldo}");
        }

        public void TransferirSaldo(double valorTransferencia, Conta contaDestino)
        {
            if(SacarSaldo(valorTransferencia))
            {
                contaDestino.DepositarSaldo(valorTransferencia);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tipoConta);
            sb.Append(" | ");

            sb.Append(nome);
            sb.Append(" | ");

            sb.Append("Saldo: ");
            sb.Append(saldo);
            sb.Append(" | ");

            sb.Append("Credito: ");
            sb.Append(credito);
            sb.Append(" | ");

            return sb.ToString();
        }
    }
}