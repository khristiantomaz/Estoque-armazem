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

        System.Console.WriteLine();
        System.Console.Write("Digite a quantidade de protudos adicionados ao estoque: ");
        int qte = int.Parse(System.Console.ReadLine());

        p.AdicionarProduto(qte);

        System.Console.WriteLine();
        System.Console.WriteLine("Dados atualizados: " + p);
           
        System.Console.WriteLine();
        System.Console.WriteLine("Digite quantas unidades gostaria de remover:");
        int rmv = int.Parse(System.Console.ReadLine());

        p.RemoverProdutos (rmv);

        System.Console.WriteLine();
        System.Console.WriteLine("Dados atualizados: " + p);


        }
    }
}