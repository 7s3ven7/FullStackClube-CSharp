namespace POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new();

            cliente.Name = "Lindosneido";

            cliente.modificarPagamento(1);

            Vendedor vendedor = new();

            vendedor.adicionarProduto("Pepsi", 5.99, 12);
            vendedor.adicionarProduto("Frango", 15.69, 24);
            vendedor.adicionarProduto("Laranja", 1.20, 120);
            vendedor.adicionarProduto("Bomba Atômica", 120000000.00, 2);
            vendedor.adicionarProduto("Maça", 2.10, 31);
            vendedor.adicionarProduto("macarrão", 3.99, 18);

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n" +
                    "1 - Produtos\n" +
                    "2 - Conta Bancaria\n" +
                    "3 - Sair\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        bool continuarProduto = true;

                        while (continuarProduto)
                        {

                            Console.WriteLine("\n" +
                                "1 - Listar Produtos\n" +
                                "2 - Comprar Produto por id\n" +
                                "3 - Voltar\n");

                            int optionProduto = Convert.ToInt32(Console.ReadLine());
                            switch (optionProduto)
                            {
                                case 1:
                                    vendedor.listarProdutos();
                                    break;
                                case 2:

                                    Console.Write("Diga o Id do produto:\n");

                                    int produtoId = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("Diga a quantity do produto:\n");

                                    int quantity = Convert.ToInt32(Console.ReadLine());

                                    if(produtoId <= vendedor.Produtos.Count() - 1)
                                    {
                                        if(cliente.verificarSaldo(cliente.consultarSaldo() * quantity))
                                        {
                                            vendedor.venderProduto(vendedor.Produtos[produtoId], quantity);
                                            cliente.pagar(cliente.consultarSaldo() * quantity);
                                        }
                                    }
                                    break;
                                case 3:
                                    continuarProduto = false;
                                    break;
                                default:
                                    Console.WriteLine("Não é uma opção >:(\n");
                                    break;
                            }
                        }
                        break;
                    case 2:

                        bool continuarContaBancaria = true;

                        while (continuarContaBancaria)
                        {
                            Console.WriteLine("\n" +
                            "1 - Verificar Saldo\n" +
                            "2 - Modificar método de pagamento\n" +
                            "3 - Voltar\n");

                            int optionConta = Convert.ToInt32(Console.ReadLine());

                            switch (optionConta) {
                                case 1:
                                    Console.WriteLine(cliente.consultarSaldo());
                                    break;
                                case 2:
                                    Console.WriteLine("\n" +
                                        "1 - Dinheiro\n" +
                                        "2 - Cartão\n" +
                                        "3 - Pix\n");

                                    int tipoPagamento = Convert.ToInt32(Console.ReadLine());

                                    if(tipoPagamento > 0 || tipoPagamento <= 3)
                                    {
                                        cliente.modificarPagamento(tipoPagamento);
                                    } else
                                    {
                                        Console.WriteLine("Método não aceito\n");
                                    }
                                        
                                    break;
                            }
                        }
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Não é uma opção >:(\n");
                        break;
                }
            }
        }
    }
}
