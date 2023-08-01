using example_factory_dotnet.Interfaces;
using example_factory_dotnet.Models;

namespace example_factory_dotnet.Services
{
    public class TarefaServiceB : ITarefaService
    {
        public Tarefa CriarTarefa()
        {
            return new Tarefa(2, "Tarefa Criada do Servico B");
        }
    }
}