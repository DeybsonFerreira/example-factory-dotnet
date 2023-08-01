using example_factory_dotnet.Interfaces;
using example_factory_dotnet.Models;

namespace example_factory_dotnet.Services
{
    public class TarefaServiceA : ITarefaService
    {
        public Tarefa CriarTarefa()
        {
            return new Tarefa(1, "Tarefa Criada do Servico A");
        }
    }
}