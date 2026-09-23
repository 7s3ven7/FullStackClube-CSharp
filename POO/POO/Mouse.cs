namespace POO
{
    public class Mouse
    {

        public string Cor { get; set; }
        public int Botoes { get; set; }
        public string Tipo { get; set; }
        
        public Mouse(string cor, int botoes, string tipo)
        {
            Cor = cor;
            Botoes = botoes;
            Tipo = tipo;
        }

        public void Clicar()
        {
            Console.WriteLine("Clicando...");
        }

        public void Rolar()
        {
            Console.WriteLine("Rolando a página...");
        }

        public void CorDoMouse()
        {
            Console.WriteLine($"Cor do Mouse: {Cor}");
        }

    }
}
