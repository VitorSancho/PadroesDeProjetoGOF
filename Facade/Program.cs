// See https://aka.ms/new-console-template for more information
using Facade.Exemplo;
using Facade.Exercicio;

Console.WriteLine("--------- EXEMPLO");


CreditoFacade cconcedeCreditoFacade = new CreditoFacade();

Cliente cliente1 = new Cliente("Vitor");

bool resultado = cconcedeCreditoFacade.ConcederEmprestimo(cliente1, 19999);

Console.WriteLine($"O emprestimo ao cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Negado"));

Console.ReadKey();

Console.WriteLine("--------- EXERCÍCIO");

ComparaPrecoFacade comparaPreco = new ComparaPrecoFacade();
var ISBN1 = "11111";
var ISBN2 = "22222";
var ISBN3 = "33333";
var livros = comparaPreco.Comparar(ISBN1);

Console.WriteLine($"Resultado da Pesquisa {ISBN1}");
foreach (var livro in livros)
{
    Console.WriteLine($"Livro {livro.Titulo} - ISBN {livro.ISBN} - Preço {livro.Preco}");
}

var livros2 = comparaPreco.Comparar(ISBN2);

Console.WriteLine($"Resultado da Pesquisa {ISBN1}");
foreach (var livro in livros2)
{
    Console.WriteLine($"Livro {livro.Titulo} - ISBN {livro.ISBN} - Preço {livro.Preco}");
}

var livros3 = comparaPreco.Comparar(ISBN2);

Console.WriteLine($"Resultado da Pesquisa {ISBN1}");
foreach (var livro in livros3)
{
    Console.WriteLine($"Livro {livro.Titulo} - ISBN {livro.ISBN} - Preço {livro.Preco}");
}

Console.ReadLine();