using System;

namespace DigitalInnovationOne.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome)
        {
                this.TipoConta = tipoConta;
                this.Saldo = Saldo;
                this.Credito = Credito;
                this.Nome = Nome;
        }

        public bool Sacar(double ValorSaque)
        {
            //Validação de Saldo
            if(this.Saldo - ValorSaque < (this.Credito * -1)){
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= ValorSaque;

            Console.WriteLine("Olá {0}, ficou em sua conta o valor: {1}.", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            
            Console.WriteLine("Olá {0}, agora o saldo em sua conta é: {1}.", this.Nome, this.Saldo);

        }

        public void Transferir(double ValorTransferencia, Conta ContaDestino)
        {
            if(this.Sacar(ValorTransferencia)){
                ContaDestino.Depositar(ValorTransferencia);


            }
        }

        public override string ToString()
        {
            String retorno ="";
            retorno += "TipoConta" + this.TipoConta + " | ";
            retorno += "Nome" + this.Nome + " | ";
            retorno += "Saldo" + this.Saldo + " | ";
            retorno += "Crédito" + this.Credito;
            return retorno;
        }
    }
}