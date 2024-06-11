// See https://aka.ms/new-console-template for more information
using Decorator;
using Decorator.Pasta;

Console.WriteLine("Programa exemplo:");

IPizza pizzaMussarela = new Pizza("Mussarela");

Console.WriteLine(pizzaMussarela.Opcionais());
Console.WriteLine(pizzaMussarela.Preco());

Console.WriteLine("Adicionando comportamento....");

var bordaRecheada = new BordaRecheadaDecorator(pizzaMussarela);
var adicionalBacon = new BaconDecorator(bordaRecheada);
var massaEspecial = new MassaEspecialDecorator(adicionalBacon);

Console.WriteLine(massaEspecial.Opcionais());
Console.WriteLine(massaEspecial.Preco());

Console.ReadLine();
