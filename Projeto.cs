namespace HellowWorld;

public class Programa
{
    static void Main()
    {

        ////Exercício - 01 e 02 - Introdução

        //var pessoa = new Humano();

        //Console.Write("Digite seu nome: ");
        //pessoa.Nome = Console.ReadLine();

        //Console.WriteLine($"Olá, {pessoa.Nome}! Seja muito bem - vindo!");

        //Console.Write("Digite seu sobrenome: ");
        //pessoa.Sobrenome = Console.ReadLine();


        //Console.WriteLine(pessoa.Sobrenome);
        //Console.WriteLine(pessoa.NomeCompleto());

        ////exercício 03 - Introdução

        //var operacao = new OperacoesMatematicas();

        //Console.Write("Digite um valor: ");
        //operacao.Valor1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Digite outro valor: ");
        //operacao.Valor2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine(operacao.Soma().ToString("F2"));
        //Console.WriteLine(operacao.Subtracao().ToString("F2"));
        //Console.WriteLine(operacao.Multiplicacao().ToString("F2"));
        //Console.WriteLine(operacao.Divisao().ToString("F2"));


        // Exercício - 04 - Introdução

        //string palavra = Console.ReadLine();

        //int contador = 0;

        //foreach (char caracter in palavra)
        //{
        //    if (char.IsWhiteSpace(caracter) == false)
        //    {
        //        contador++;
        //    }
        //}
        //Console.WriteLine(contador);

        // Exercício - 05 - Introdução

        //bool ehPlacaaValida = false;

        //do
        //{
        //    Console.WriteLine("Digite a placa do carro: ");
        //    string placa = Console.ReadLine()?.Trim() ?? string.Empty;

        //    bool tamanhaDaPlaca = placa.Length == 7;

        //    bool comecoDaPlaca = tamanhaDaPlaca && placa.Substring(0, 3).All(char.IsLetter);

        //    bool fimDaPlaca = tamanhaDaPlaca && placa.Substring(3, 4).All(char.IsDigit);

        //    if (comecoDaPlaca && fimDaPlaca)
        //    {
        //        ehPlacaaValida = true;

        //        Console.WriteLine("Verdadeira");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Essa placa não é valida");
        //    }
        //}
        //while (!ehPlacaaValida);

        // Exercício - 06 - Introdução

        var datas = new Horarios();


        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine(datas.FormatoCompleto());
                break;
            case 2:
                Console.WriteLine(datas.FormatoTradicional());
                break;
            case 3:
                Console.WriteLine(datas.HorarioMilitar());
                break;
            case 4:
                Console.WriteLine(datas.DataMesPorExtenso());
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;


        }


        

        


    }
}



