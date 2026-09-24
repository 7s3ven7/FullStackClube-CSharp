namespace Sistema_de_Usuarios
{
    public abstract class Usuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {

            Nome = nome;
            Email = email;
            DefinirSenha(senha);
        }

        private void DefinirSenha(string senha)
        {

            if(senha.Length >= 6)
            {
                Senha = senha;
            }

            Console.WriteLine("A senha precisa ter no mínimo 6 caractéres");

        }

        public abstract void ExibirInformacao();

    }
}
