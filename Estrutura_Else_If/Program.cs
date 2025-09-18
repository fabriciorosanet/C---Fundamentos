Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em Recuperação");
}
else if (nota >= 6.0 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno aprovado com louvor");
}
Console.WriteLine("Fim do Programa");
Console.ReadKey();