namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
