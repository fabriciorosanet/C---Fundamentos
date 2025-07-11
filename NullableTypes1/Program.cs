// See https://aka.ms/new-console-template for more information

Console.WriteLine("Nullable Types");

Nullable<int> a = null;
Nullable<double> b = null;
Nullable<bool> c = null;

int? d = null; // Usando o operador de interrogação para tipos anuláveis
double? e = null;
bool? f = null;

int? g = 1;

int h = g ?? 0; // Usando o operador de coalescência nula para atribuir um valor padrão se g for nulo

int? i = 4;
int? j = 3;
int? k = i * j;

int? w = null;
if (w.HasValue)
{
    Console.WriteLine($"O valor de w é: {w.Value}");
}
else
{
    Console.WriteLine("w é nulo");
}


Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);

Console.WriteLine(g);

Console.WriteLine(k);
Console.WriteLine(w);

Console.ReadKey();