// See https://aka.ms/new-console-template for more information
using Proxy.exemplo;
using Proxy.exercicio;

Console.WriteLine("#### exemplo de implementação de proxy");

Console.WriteLine("Funcionario com perfil 'Programados acessando a pasta compartilhada proxy'");
Funcionario func1 = new Funcionario("Vitor", "Programador");
PastaCompartilhadaProxy pastaProxy1 = new PastaCompartilhadaProxy(func1);
pastaProxy1.OperacaoDeLeituraGravacao();

//acesso Usuario
Console.WriteLine("Funcionario com perfil 'Usuario' acessando a pasta proxy");
Funcionario func2 = new Funcionario("Vitor 2", "Usuario");
PastaCompartilhadaProxy pastaProxy2 = new PastaCompartilhadaProxy(func2);
pastaProxy2.OperacaoDeLeituraGravacao();

//acesso CEO
Console.WriteLine("Funcionario com perfil 'CEO' acessando a pasta proxy");
Funcionario func3 = new Funcionario("Vitor 3", "CEO");
PastaCompartilhadaProxy pastaProxy3 = new PastaCompartilhadaProxy(func3);
pastaProxy3.OperacaoDeLeituraGravacao();

Console.ReadKey();

///////////////////////////////////
Console.WriteLine("#################### exercicio");

InternetProxy request1 = new InternetProxy();
request1.AcessaSite("youtube");

InternetProxy request2 = new InternetProxy();
request2.AcessaSite("globo");

InternetProxy request3 = new InternetProxy();
request2.AcessaSite("google");

Console.ReadKey();
