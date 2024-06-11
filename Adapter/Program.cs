// See https://aka.ms/new-console-template for more information
using Adapter.Exemplo;
using Adapter.Exercicio;

Console.WriteLine("Hello, World!");


////// exemplo
var alunosArray = SistemaEscolar.GetListaAlunosMensalidade();

var calculo = new AlunosAdapter();
calculo.ProcessaCalculoMensalidade(alunosArray);
///////////
///

////// exercicio
var grafico = new GraficoAdapter();
grafico.Titulo = "Teste";
grafico.XValores = new List<string>() { "valor1", "valor2" };
grafico.YValores = new List<int>() { 1, 2};
grafico.GerarGrafico(grafico.Titulo,grafico.XValores, grafico.YValores);
