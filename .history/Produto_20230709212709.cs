namespace Course
{
    public class Produto

    {
        static void Main(string[] args)
        {
            Estoque p = new Estoque();

        System.Console.WriteLine("Entre o nome do Produto!");

        System.Console.Write("Nome:");
        p.Nome = System.Console.ReadLine();

        System.Console.Write("Preço:");
        p.Preco = double.Parse(System.Console.ReadLine());

        System.Console.Write("Quantidade no estoque:");
        p.Quantidade = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Dados do produto: " + p) ;



        }
    }
}