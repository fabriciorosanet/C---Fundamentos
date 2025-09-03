/*
* Precedência de operadores:
* Define a ordem em que os operadores são avaliados em uma expressão.
* Operadores com maior precedência são avaliados antes dos operadores com menor precedência.
* Exemplo: Na expressão 3 + 5 * 2, o operador de multiplicação (*) tem maior precedência do que o operador de adição (+).
* Portanto, a multiplicação é realizada primeiro, resultando em 3 + (5 * 2) = 3 + 10 = 13.
* 
* Associatividade de operadores:
* Define a ordem em que os operadores com a mesma precedência são avaliados.
* A maioria dos operadores em C# é associativa à esquerda, o que significa que eles são avaliados da esquerda para a direita.
* Exemplo: Na expressão 10 - 4 - 2, ambos os operadores de subtração (-) têm a mesma precedência e são associativos à esquerda.
* Portanto, a avaliação ocorre da esquerda para a direita: (10 - 4) - 2 = 6 - 2 = 4.
* 
* Alguns operadores, como o operador de atribuição (=), são associativos à direita.
* Exemplo: Na expressão a = b = c, a avaliação ocorre da direita para a esquerda: a = (b = c).
* 
* Parênteses:
* Podem ser usados para alterar a ordem de avaliação das expressões.
* Expressões dentro de parênteses são avaliadas primeiro, independentemente da precedência ou associatividade dos operadores envolvidos.
* Exemplo: Na expressão (3 + 5) * 2, os parênteses indicam que a adição deve ser realizada antes da multiplicação, 
* resultando em (3 + 5) * 2 = 8 * 2 = 16.
* Ordem de precedência dos operadores (do mais alto para o mais baixo): Aritméticos, Relacionais, Lógicos, Atribuição.
 * Ordem *, /, % > +, - > <, <=, >, >= > ==, != > && > || > =
 * Ordem de proridade de precedencia nos operadores !, &&, ||
 */


//consulte a documentacao: https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170
Console.WriteLine("## Precedência de Operadores ##\n");

int x = 10 - 2 * 3; // Multiplicação primeiro, depois subtração
int y = (10 - 2) * 3; // Parênteses alteram a ordem, subtração primeiro, depois multiplicação
Console.WriteLine($"Resultado de x é: {x}");
Console.WriteLine($"Resultado de y é: {y}");

Console.WriteLine("*************************************");

var b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);