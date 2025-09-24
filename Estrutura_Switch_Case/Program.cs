Console.WriteLine("Estrutura switch case");

//Console.Write("Informe o valor da compra: ");
//decimal valorCompra = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Informe o numero de parcelas referente a esta compra: ");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch (numeroParcelas) // variavel que será avaliada
//{
//	case 1:
//		Console.WriteLine($"Valor da prestação R$ {valorCompra/numeroParcelas},00 sem juros");
//		break;
//	case 2:
//		Console.WriteLine($"Valor da prestação R$ {valorCompra/numeroParcelas},00 sem juros");
//		break;
//	case 3:
//		Console.WriteLine($"Valor da prestação R$ {valorCompra/numeroParcelas},00 sem juros");
//		break;
//	case 4:
//        Console.WriteLine($"Valor da prestação R$ {valorCompra / numeroParcelas},00 sem juros");
//        break;
//    case 5:
//        Console.WriteLine($"Valor da prestação R$ {valorCompra / numeroParcelas},00 sem juros");
//        break;
//	case 6:
//		Console.WriteLine($"Valor da prestação R$ {valorCompra/numeroParcelas},00 sem juros");
//		break;
//	default:
//		Console.WriteLine($"Número de parcelas inválido. O valor seguirá avisa no total de {valorCompra}");
//		break;
//}

//Console.WriteLine("Fim do Programa");

Console.Write("Informe o número inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2) // expressao
{
	case 0:
		Console.WriteLine($"Número {numero} é par");
		break;
	case 1:
		Console.WriteLine($"Número {numero} é impar");
		break;
}
Console.WriteLine("Fim do Programa");

