namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();

            gato.Falar();  

            Animal cachorro = new Cachorro();

            cachorro.Falar();
        }
    }
}
