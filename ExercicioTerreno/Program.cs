using System.Globalization;

namespace ExercicioTerreno
{
    internal class Program
{
    static void Main(string[] args)
    {
            double area,preco;
            Console.WriteLine("Digite largura do terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite comprimento do terreno:");
            double comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = largura * comprimento;

            Console.WriteLine("Digite valor do M2");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preco = valor * area;

            Console.WriteLine("AREA: "+ area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO: " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
}
}
