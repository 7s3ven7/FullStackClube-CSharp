namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mouse();

            //carro();

            //contaBancaria();

            pessoa();
        }

        static void mouse()
        {
            Mouse mouseBranco = new Mouse("Branco", 2, "Sem Fio");

            Console.WriteLine($"Cor do mouse: {mouseBranco.Cor}");
            Console.WriteLine($"Quantidade de Botões do mouse: {mouseBranco.Botoes}");
            Console.WriteLine($"tipo do mouse: {mouseBranco.Tipo}");

            mouseBranco.Clicar();
            mouseBranco.Rolar();

            Mouse mousePreto = new Mouse("Preto", 6, "Com Fio");

            mousePreto.CorDoMouse();
        }
    
        static void carro()
        {
            Carro carroBranco = new Carro();

            carroBranco.Cor = "Branco";
            carroBranco.Modelo = "Civic";
            carroBranco.Velocidade = 0;

            carroBranco.Acelerar();
        }

        static void contaBancaria()
        {

            ContaBancaria minhaConta = new ContaBancaria();

            minhaConta.Depositar(50);

            minhaConta.SaldoAtual();
        }

        static void pessoa()
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Wesley";
            funcionario.Idade = 19;
            funcionario.Cargo = "Programador";
            funcionario.Salario = 1500;

            funcionario.Trabalhar();

            funcionario.Falar();

            Cliente cliente = new();

            cliente.Nome = "Fabiano da Silva";
            cliente.Idade = 37;
            cliente.MetodoDePagamento = "Pix e Cartão";

            cliente.VerSaldo();

            cliente.TiposDePagamento();
        }
    }
}