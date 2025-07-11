// See https://aka.ms/new-console-template for more information

Console.WriteLine("Definindo variaveis do tipo string, object e dynamic");

string nome = "João";
String sobrenome = "Silva";

string valor = "Isso é uma string";
valor  = "Agora é outra string";
valor = "outro locar na memoria para a string";

object nota = 10;
object valor1 = 8.55m;
object nome2 = "Maria";
object ativa = true;
object letra = 'A';

dynamic nota1= 10;
dynamic valor2 = 8.55m;
dynamic nome3 = "Maria";
dynamic ativa1 = true;
dynamic letra1 = 'A';

Console.WriteLine(nome);
Console.WriteLine(sobrenome);

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome2);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.WriteLine(nota1);
Console.WriteLine(valor2);
Console.WriteLine(nome3);
Console.WriteLine(ativa1);
Console.WriteLine(letra1);

Console.ReadLine();