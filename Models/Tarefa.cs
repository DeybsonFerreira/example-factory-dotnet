namespace example_factory_dotnet.Models
{
    public class Tarefa
    {
        public Tarefa(int id, string nome)
        {
            this.Id = id;
            this.Name = nome;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}