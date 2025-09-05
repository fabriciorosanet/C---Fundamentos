Console.WriteLine("## Estrutura de Controle IF e Else");

int aluno = 0;
Console.Write("Digite a nota do aluno: ");
aluno = Convert.ToInt32(Console.ReadLine());
if (aluno > 5) 
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}
Console.WriteLine("Fim do Programa");