int loop = 0;
double nota1, nota2, media;
string nome, resultado;

Console.WriteLine("Seja bem vindo ao 3º teste! " + Environment.NewLine);

while (loop == 0) {

    Console.WriteLine("Por gentileza, informe o nome do aluno em questão: ");

    nome = Console.ReadLine();

    Console.WriteLine("Digite a nota do 1º semestre: ");

    nota1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do 2º semestre: ");

    nota2 = int.Parse(Console.ReadLine());

    media = (nota1 + nota2) / 2;

    if (media < 6.5) {

        resultado = "Reprovado";

    } else {

        resultado = "Aprovado";

    }

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"A média é: {media}");
    Console.WriteLine($"O aluno foi: {resultado}" + Environment.NewLine);

}