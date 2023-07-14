int qtdProva = 0;
double nota, media, totalNota = 0;
string nome;

Console.WriteLine("Boas vindas ao teste 02! Para inicio de conversa, digite seu nome por gentileza: ");

    nome = Console.ReadLine();

while (nome != null) {

    Console.WriteLine($"{nome} nos informe a nota que você tirou em sua prova: ");

        nota = int.Parse(Console.ReadLine());

        qtdProva++;

        totalNota = totalNota + nota;

        media = totalNota / qtdProva;

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Quantidade de Provas: {qtdProva}");
    Console.WriteLine($"Total de Nota: {totalNota}");
    Console.WriteLine($"Sua média é de: {media}" + Environment.NewLine);

}