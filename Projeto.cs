namespace HellowWorld;

public class Programa
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        var pessoa = new Humano(nome);
        Console.WriteLine($"Seu nome é {pessoa.Nome}");



    }
}