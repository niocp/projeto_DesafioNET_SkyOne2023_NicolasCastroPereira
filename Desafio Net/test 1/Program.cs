double nota1, nota2, media;

Console.WriteLine("Digite a nota do primeiro semestre: ");

nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota do segundo semestre: ");

nota2 = int.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

Console.WriteLine($"A média calculada foi de {media}");