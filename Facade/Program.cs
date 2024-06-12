// See https://aka.ms/new-console-template for more information
using Facade.Exemplo;

Console.WriteLine("--------- EXEMPLO");


CreditoFacade cconcedeCreditoFacade = new CreditoFacade();

Cliente cliente1 = new Cliente("Vitor");

bool resultado = cconcedeCreditoFacade.ConcederEmprestimo(cliente1, 19999);

Console.WriteLine($"O emprestimo ao cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Negado"));

Console.ReadKey();