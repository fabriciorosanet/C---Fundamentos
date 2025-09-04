Console.WriteLine("## Operadorador Uniário e Ternário ##");

// Operador Uniário

int positivo = 1;
int resultado;

resultado = +positivo; // Operador unário de positivo
Console.WriteLine($"Operador unário de positivo: {resultado}");

//Operador unário de negativo
Console.WriteLine("Informe o número: ");
var numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {numero} é {-numero}");

//Operador Condicional Ternário (?:)
//Sintaxe: condição ? valor_se_verdadeiro : valor_se_falso;

Console.WriteLine("Informe o número de cartas de baralho: ");
var cartas = Convert.ToInt32(Console.ReadLine());
var tipoDeBaralho = cartas == 52 ? "Baralho Francês" : "Baralho Brasileiro";
Console.WriteLine($"Qual será o tipo de baralho: {tipoDeBaralho}");

//Outro exemplo de operador ternário

Console.WriteLine("Informe a sua idade: ");
var idade = Convert.ToInt32(Console.ReadLine());
var categoria = idade < 12 ? "Criança" : idade < 18 ? "Adolescente" : "Adulto";
Console.WriteLine($"Sua categoria é: {categoria}");
