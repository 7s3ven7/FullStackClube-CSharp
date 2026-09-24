using System.Reflection.Metadata.Ecma335;

namespace POO
{
    public class Cliente : Pessoa
    {
        private double Saldo { get; set; }
        public string MetodoDePagamento { get; set; }


        public void VerSaldo()
        {
            Console.WriteLine($"Saldo do cliente *{Nome}*: {Saldo}");
        }

        public void TiposDePagamento()
        {
            Console.WriteLine($"Paga a partir do(s) método(s): {MetodoDePagamento}");
        }

    }
}
