using System.ComponentModel;

namespace EstruturaDecisaoRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ifFunction();

            //switchFunction();

            //forFunction();

            //whileFunction();

            //funcaoProdutos();

            Desafio();
        }

        static void ifFunction()
        {
            Console.WriteLine("Digite a nota do aluno!\n");
            Console.WriteLine("Nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado :)");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Recuperação :|");
            }
            else
            {
                Console.WriteLine("Reprovado :(");
            }

        }

        static void switchFunction()
        {
            Console.WriteLine("Digite o status do aluno:" +
                "\n 1 - Aprovado" +
                "\n 2 - Recuperação" +
                "\n 3 - Reprovado");

            int status = Convert.ToInt32(Console.ReadLine());

            switch (status)
            {
                case 1:
                    Console.Write("Aluno aprovado :)");
                    break;
                case 2:
                    Console.Write("Aluno em recuperação :|");
                    break;
                case 3:
                    Console.Write("Aluno Reprovado :(");
                    break;
                default:
                    Console.Write("Status Inválido >:(" +
                        "\nTente Novamente! \n\n");
                    switchFunction();
                    break;
            }
        }
        static void forFunction()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Contagem: {i}\n");
            }
        }

        static void whileFunction()
        {
            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine($"Numero: {contador}\n");
                contador++;
            }
        }

        static void funcaoProdutos()
        {
            Console.WriteLine("Sistema de vendas\n");

            double total = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}°Produto");
                Console.WriteLine("\nNome do produto:");

                string nome = Console.ReadLine();

                Console.WriteLine("\nQuantidade:");

                int quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPreço do produto:");

                double preco = Convert.ToDouble(Console.ReadLine());

                double subTotal = quantidade * preco;
                total += subTotal;

                Console.WriteLine($"Valor total da compra: {subTotal}\n");
            }

            if (total >= 200)
            {
                double desconto = total * 0.1;

                total -= desconto;

                Console.WriteLine($"Desconto de 10% aplicado :)" +
                    $"\n Total: R${total}");
            }

            Console.WriteLine("Qual a forma de pagamento!" +
                "\n1 - Dinheiro" +
                "\n2 - Cartão" +
                "\n3 - Pix");

            int tipoPagamento = Convert.ToInt32(Console.ReadLine());

            switch (tipoPagamento)
            {
                case 1:
                    Console.WriteLine("\nPagamento em dinheiro selecionado");
                    break;
                case 2:
                    Console.WriteLine("\nPagamento em cartão selecionado");
                    break;
                case 3:
                    Console.WriteLine("\nPagamento em Pix selecionado");
                    break;
                default:
                    Console.WriteLine("\nPagamento indefinido");
                    break;
            }

        }
        static void Desafio()
        {

            Console.WriteLine("Bem vindo ao meu Software de criação de produtos\n");

            bool continuarCriando = true;

            List<(string nome, double valor)> produtos = new List<(string nome, double valor)>();

            while (continuarCriando)
            {

                if (produtos.Count() == 0)
                {
                    Console.WriteLine("A loja é nova então não tem produtos :(\n");
                }

                Console.WriteLine("\nOpções:" +
                    "\n 1 - Criar Produto" +
                    "\n 2 - Listar Produto" +
                    "\n 3 - Ir embora porque não tem como pagar :(");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produtos.Add(criarProduto());
                        break;
                    case 2:
                        listarProdutos(produtos);
                        break;
                    case 3:
                        continuarCriando = false;
                        break;
                    default:
                        Console.WriteLine("\nNão é uma opção >:(\n");
                        break;
                }
            }

        }

        static ValueTuple<string, double> criarProduto()
        {

            Console.WriteLine("\nNome Do Produto:");

            string nome = Console.ReadLine();

            Console.WriteLine("\nPreço Do Produto (separador de casas de cimais = ','):");

            double preco = Convert.ToDouble(Console.ReadLine());

            return (nome, preco);
        }

        static void listarProdutos(List<(string nome, double valor)> produtos)
        {
            for (int i = 0; i < produtos.Count(); i++)
            {
                Console.WriteLine($"Produto {i + 1}°: \nnome - {produtos[i].nome}\npreço - {produtos[i].valor}\n");
            }
        }
    }
}
