namespace Sistema_de_Usuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new();

            Admin admin = new("Wesley", "wesley@gmail.com", "wesley123");

            Comum comum = new("usuario1", "usuario1@gmail.com", "321123");

            sistema.AdicionarUsuario(admin);
            sistema.AdicionarUsuario(comum);

            sistema.ListarUsuarios();

            admin.RedefinirSenha(comum);

            sistema.RemoverUsuario(comum.Email);

            sistema.ListarUsuarios();
        }
    }
}
