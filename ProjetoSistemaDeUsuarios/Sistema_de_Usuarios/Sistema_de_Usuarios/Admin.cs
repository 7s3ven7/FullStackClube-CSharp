namespace Sistema_de_Usuarios
{
    public class Admin : Usuario
    {

        public Admin(string nome, string email,string senha) : base(nome, email, senha) { }

        public override void ExibirInformacao()
        {
            Console.WriteLine("usuário admin");
        }

        public void RedefinirSenha(Usuario usuario)
        {
            Console.WriteLine($"Senha do usuário: {usuario.Nome} senha redefinida pelo admin: {Nome}");
        }

    }
}
