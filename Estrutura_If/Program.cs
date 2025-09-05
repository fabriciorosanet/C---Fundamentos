Console.WriteLine("## Estrutura de Controle if");

/*
 * O bloco de controle if 
 * só é executado se a condição for verdadeira.
 * sintaxe1:
 *  if(condição --expressao booleana--)
 *  {
 *      executa o bloco de instrução se expressão for verdadeira (true)
 *      instrução 1
 *      instrução 2
 *  }
 *  sintaxe2:
 *      if (condição --expressao booleana--)
 *          execução de uma única instrução se expressão for verdadeira (true)
 *   obs.: se o bloco de instrução tiver apenas uma instrução, as chaves são opcionais.       
 */

/*
 * Exercício:
 * 1. Solicite o nome do cliente
 * 2. Se o nome do cliente for "Maria" ou "João", exiba a mensagem "Cliente especial"
 * 3. Solicite o valor da compra
 * 4. Se o valor da compra for maior que 100, aplique um desconto de 10%
 * 5. Exiba o valor final a pagar
 */
Console.WriteLine("Digite o nome do cliente:");
string nomeCliente = Console.ReadLine();

if (nomeCliente == "Maria" || nomeCliente == "João")
{
    Console.WriteLine("Cliente especial");
}

Console.WriteLine("Digite o valor da compra: ");
double valorCompraExercicio = double.Parse(Console.ReadLine());

double valorDescontoExercicio = 0;

if (valorCompraExercicio > 100 && (nomeCliente == "Maria" || nomeCliente == "João"))
{
    valorDescontoExercicio = valorCompraExercicio * 0.1;
}

double valorFinalPagar = valorCompraExercicio - valorDescontoExercicio;
Console.WriteLine($"Valor final a pagar: {valorFinalPagar}");

