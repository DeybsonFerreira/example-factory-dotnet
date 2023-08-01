using example_factory_dotnet.Factory;
using example_factory_dotnet.Interfaces;
using example_factory_dotnet.Models;
using example_factory_dotnet.Services;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Iniciando a aplicação");
var serviceCollection = new ServiceCollection();

//configurar injeção de dependencia
serviceCollection.AddScoped<TarefaServiceA>();
serviceCollection.AddScoped<ITarefaService, TarefaServiceA>();
serviceCollection.AddScoped<TarefaServiceB>();
serviceCollection.AddScoped<ITarefaService, TarefaServiceB>();

var serviceProvider = serviceCollection.BuildServiceProvider();

// Obter o serviço necessário 
TarefaServiceFactory factory = new TarefaServiceFactory(serviceProvider);
ITarefaService instancia = factory.CriarTarefaService("A");
Tarefa tarefa = instancia.CriarTarefa();


Console.WriteLine(tarefa.Name);