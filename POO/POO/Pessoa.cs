namespace POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"{Nome} está falando");
        }
    }
}
