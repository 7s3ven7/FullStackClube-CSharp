namespace POO
{
    public class Carro
    {

        public string Cor {  get; set; }
        public string Modelo {  get; set; }
        public double Velocidade { get; set; }


        public void Acelerar()
        {
            Velocidade += 10;

            Console.WriteLine($"Acelerando, Velocidade: {Velocidade}Km/h");
        }
    }
}
