using System.Formats.Asn1;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variaveis");

            int inteiro = 1;
            float quebrado = 1.10f;
            double dobre = 10.10;
            decimal decimais = 1.10m;

            int idade = 19;
            float altura = 1.75f;
            double preco = 5.99;
            decimal salario = 1500;

            Console.WriteLine($"Tipo int: {idade}");
            Console.WriteLine($"Tipo float: {altura}");
            Console.WriteLine($"Tipo double: {preco}");
            Console.WriteLine($"Tipo decimal: {salario}");

            Console.WriteLine("\n");

            char inicial = 'A';
            string formacao = "Formação C#";

            Console.WriteLine($"Tipo char: {inicial}");
            Console.WriteLine($"Tipo string: {formacao}");

            Console.WriteLine("\n");

            bool maiorDeIdade = true;

            Console.WriteLine($"Tipo bool: {maiorDeIdade}");

            Console.WriteLine("\n");

            var variado = "Valor de tipo declarado altomaticamente";

            Console.WriteLine($"Tipo var: {variado}");

            Console.WriteLine("\n");

            float nota1 = 10f;
            float nota2 = 5f;

            Console.WriteLine($"Nota1 + Nota2 = {nota1 + nota2}");
            Console.WriteLine($"Nota1 - Nota2 = {nota1 - nota2}");
            Console.WriteLine($"Nota1 * Nota2 = {nota1 * nota2}");
            Console.WriteLine($"Nota1 / Nota2 = {nota1 / nota2}");

            Console.WriteLine("\n");

            string produto = "Café";
            int quantidade = 3;
            float valorProduto = 8.50f;
            float total = quantidade * valorProduto;

            Console.WriteLine($"Nosso produto: {produto}");
            Console.WriteLine($"Valor Total: {total}");

            Console.WriteLine("\n");

            // Extra

            Console.WriteLine("Calculo da área de um triângulo retângulo\n");
            Console.WriteLine("Cateto adjacente ou Cateto oposto:");

            string valor = Console.ReadLine();
            double catetoAdjecente = double.Parse(valor);

            double areaTotal = (catetoAdjecente * catetoAdjecente) / 2;

            Console.WriteLine("\n");
            Console.WriteLine("Área do triângulo retângulo:\n");
            Console.WriteLine($"(Cateto_Adjacente * Cateto_Adjacente) / 2 = {areaTotal}");

        }
    }
}
