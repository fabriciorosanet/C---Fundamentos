// See https://aka.ms/new-console-template for more information

Console.WriteLine("Atributos valores a double, float e decimal");
Console.WriteLine();
double valor1 = 1.234;
float valor2 = 1.234f;
decimal valor3 = 1.234m;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

Console.ReadLine();

Console.WriteLine("Comparando a precisão dos tipos de dados floar, double e decimal");

float valorFloat = 1f / 3f;
double valorDouble = 1d / 3d;
decimal valorDecimal = 1m / 3m;

Console.WriteLine(valorFloat);
Console.WriteLine(valorDouble);
Console.WriteLine(valorDecimal);

Console.ReadLine();