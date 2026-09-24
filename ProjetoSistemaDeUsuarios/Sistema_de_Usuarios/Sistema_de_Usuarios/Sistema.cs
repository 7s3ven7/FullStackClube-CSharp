namespace Sistema_de_Usuarios
{
    public class Sistema
    {

        private List<Usuario> Usuarios = new();

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} adicionado :)");
        }

        public void RemoverUsuario(string email)
        {
            Usuario usuario = BuscarUsuario(email);

            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                Console.WriteLine($"Usuário {usuario.Nome} removido :(");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado");
            }

        }

        public Usuario BuscarUsuario(string email)
        {

            foreach(var usuario in Usuarios)
            {
                if (usuario.Email == email)
                {
                    return usuario;
                }
            }

            return null;
        }

        public void ListarUsuarios()
        {
            foreach (var usuario in Usuarios)
            {
                usuario.ExibirInformacao();
            }
        }
    }
}
