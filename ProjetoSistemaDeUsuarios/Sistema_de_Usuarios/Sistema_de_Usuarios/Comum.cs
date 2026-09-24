namespace Sistema_de_Usuarios
{
    public class Comum : Usuario
    {

        public Comum(string nome, string email, string senha) : base(nome, email, senha) { }

        public override void ExibirInformacao()
        {
            Console.WriteLine($"Usuário {Nome} e Email {Email}");
        }
    }
}
