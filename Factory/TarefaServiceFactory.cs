using example_factory_dotnet.Interfaces;
using example_factory_dotnet.Services;
using Microsoft.Extensions.DependencyInjection;

namespace example_factory_dotnet.Factory
{
    public class TarefaServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public TarefaServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public ITarefaService CriarTarefaService(string tipo)
        {
            switch (tipo)
            {
                case "A":
                    return _serviceProvider.GetRequiredService<TarefaServiceA>();
                case "B":
                    return _serviceProvider.GetRequiredService<TarefaServiceB>();
                default:
                    throw new ArgumentException("Tipo de TarefaService inválido.");
            }
        }
    }
}