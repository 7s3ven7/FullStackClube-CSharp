namespace POO
{
    public class ContaBancaria
    {

        private double Saldo { get; set; } = 0;

        public void Depositar(double saldo)
        {
            if (saldo < 0)
            {
                Console.WriteLine("O valor para depositar não pode ser negativo");
                return;
            }
            else
            {
                Saldo += saldo;
            }
        }

        public void SaldoAtual()
        {
            Console.WriteLine(Saldo);
        }

    }
}
