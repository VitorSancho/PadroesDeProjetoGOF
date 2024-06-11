// See https://aka.ms/new-console-template for more information
using Composite;
using Composite.Exemplo;
using Composite.Exercicio;

Console.WriteLine("Hello, World!");


Organizacao organizacao = new Organizacao { Nome = "Teste SA" };

Organizacao departamentoTI = new Organizacao { Nome = "TI" };
departamentoTI.Add(new Funcionario { Nome = "Testinho", Horas = 9 });
departamentoTI.Add(new Funcionario { Nome = "Eita", Horas = 5 });
departamentoTI.Add(new Funcionario { Nome = "Foi em boa hora", Horas = 1 });

Organizacao departamentoRH = new Organizacao { Nome = "RH" };
departamentoRH.Add(new Funcionario { Nome = "Silva", Horas = 6 });
departamentoRH.Add(new Funcionario { Nome = "Junin", Horas = 9 });

organizacao.Add(departamentoRH);
organizacao.Add(departamentoTI);

organizacao.GetHoraTrabalhada();

Console.ReadLine();

///////////////

Grupo prova = new Grupo();

Grupo provaMatematica = new Grupo { Descricao = "Prova Matematica" };
provaMatematica.Add(new Questao { Descricao = "Questao 1" });
provaMatematica.Add(new Questao { Descricao = "Questao 2" });
provaMatematica.Add(new Questao { Descricao = "Questao 3" });

Grupo provaFisica = new Grupo { Descricao = "Prova Fisica" };
Grupo topicoOtica = new Grupo { Descricao = "Topico Otica" };
provaFisica.Add(topicoOtica);
Grupo topicoMecanica = new Grupo { Descricao = "Topico Mecanica" };
provaFisica.Add(topicoMecanica);
topicoMecanica.Add(new Questao { Descricao = "Questao 1.1" });
topicoMecanica.Add(new Questao { Descricao = "Questao 1.2" });
topicoOtica.Add(new Questao { Descricao = "Questao 2.1" });

Grupo provaGeografia = new Grupo { Descricao = "Prova Grografia" };
provaGeografia.Add(new Questao { Descricao = "Questao 1" });
provaGeografia.Add(new Questao { Descricao = "Questao 2" });

prova.Add(provaGeografia);
prova.Add(provaFisica);
prova.Add(provaMatematica);

prova.Exibir();

Console.ReadLine();