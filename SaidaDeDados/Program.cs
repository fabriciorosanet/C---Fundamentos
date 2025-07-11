// See https://aka.ms/new-console-template for more information

Console.WriteLine("Saida de dados : formatacao");
Console.WriteLine();

// Exibindo dados formatados com interpolação de strings : $ -> a interpolação de strings {}
int idade = 30;
string nome = "João";
Console.WriteLine($"{nome} tem Idade: {idade} anos");


// concatenando strings usa o sinal de mais +
Console.WriteLine(nome + " tem " + idade + " anos");

// usando placeholders : usa {} com numeracao com inicio em zero
Console.WriteLine("Nome: {0}, Idade: {1} anos", nome, idade);

Console.ReadLine();
