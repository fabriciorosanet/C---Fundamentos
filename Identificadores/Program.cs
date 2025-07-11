// See https://aka.ms/new-console-template for more information

Console.WriteLine("Definindo Identificadores");
Console.WriteLine();


//identificadores válidos

string nome;
string sobrenome;
int idade;
int _valor;
int idade1;

//identificadores inválidos
//int 5idade; 
//int @int; 
//int valor$; 

// nome de variaveis : camelCase

string nomeCompleto;
string sobrenomeCompleto;
string desconto_Total;

Console.ReadLine();

// constantes : maiúsculas
const double PI = 3.14;

// nome de classes : PascalCase

class PessoaFisica
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int Idade { get; set; }
    
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}");
    }
}