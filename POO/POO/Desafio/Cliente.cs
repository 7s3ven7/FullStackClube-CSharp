namespace POO
{
    public class Cliente : Pessoa
    {
        private int TipoPagamento { get; set; }

        public void modificarPagamento(int tipoPagamento)
        {
            switch (tipoPagamento) {
                case 1:
                    TipoPagamento = 1;
                    Console.WriteLine("Pagamento em dinheiro selecionado");
                    break;
                case 2:
                    TipoPagamento = 2;
                    Console.WriteLine("Pagamento em cartão selecionado");
                    break;
                case 3:
                    TipoPagamento = 3;
                    Console.WriteLine("Pagamento em pix selecionado");
                    break;
                default:
                    Console.WriteLine("Não é um método de pagamento aceito");
                    break;
            }
        }

        public void pagar(double saldo)
        {
            if (saldo < 0)
            {
                Console.WriteLine("Não pode pagar com saldo negativo!");
            }
            else
            {
                Saldo -= saldo;
                Console.WriteLine($"{Name} Pagou: {saldo}R$!");
            }
        }

        public double consultarSaldo()
        {
            return Saldo;
        }

        public bool verificarSaldo(double saldo)
        {
            if(saldo >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
