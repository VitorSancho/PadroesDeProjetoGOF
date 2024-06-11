// See https://aka.ms/new-console-template for more information
using Decorator;
using Decorator.Exercicio;
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


Console.WriteLine("-----------------------------------");

Console.WriteLine("Programa exercicio");

ICafe cafeFiltrado = new CafeFiltrado();
Console.WriteLine(cafeFiltrado.Descricao());
Console.WriteLine(cafeFiltrado.Preco());

var adicaoDeChocolate = new AdicionalChocolate(cafeFiltrado);
Console.WriteLine(adicaoDeChocolate.Descricao());
Console.WriteLine(adicaoDeChocolate.Preco());

var adicaoDeLeite = new AdicionalLeite(adicaoDeChocolate);
Console.WriteLine(adicaoDeLeite.Descricao());
Console.WriteLine(adicaoDeLeite.Preco());

ICafe cafeExpressao = new CafeFiltrado();
Console.WriteLine(cafeExpressao.Descricao());
Console.WriteLine(cafeExpressao.Preco());

var adicaoDeChocolateAoExpresso = new AdicionalChocolate(cafeExpressao);
Console.WriteLine(adicaoDeChocolateAoExpresso.Descricao());
Console.WriteLine(adicaoDeChocolateAoExpresso.Preco());

var adicaoDeLeiteAoExpresso = new AdicionalLeite(adicaoDeChocolateAoExpresso);
Console.WriteLine(adicaoDeLeiteAoExpresso.Descricao());
Console.WriteLine(adicaoDeLeiteAoExpresso.Preco());

Console.ReadLine();
