using bytebank;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        private string _conta;

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        private int _numero_agencia;

        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_Agencia { get; set; }
        private double saldo;

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_Agencia = numero_agencia;
            Conta = conta;
        }


        public static int TotalDeContasCriadas { get; set; }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar (double valor) 
        { 
            saldo = saldo + valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
        //public void ExibirDadosDaConta()
        //{
        //    Console.WriteLine("Titular :" + titular);
        //    Console.WriteLine("Conta :" + conta);
        //    Console.WriteLine("Número Agência :" + numero_agencia);
        //    Console.WriteLine("Nome Agência :" + nome_agencia);
        //    Console.WriteLine("Saldo: " + saldo);
        //}

        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return ;
        //    }
        //    else
        //    {
        //        saldo = valor;
        //    }
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
    }
}