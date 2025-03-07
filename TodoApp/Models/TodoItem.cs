namespace TodoApp.Models
{
    public class TodoItem
    {
        // Identificador único da tarefa
        public int Id { get; set; }
        
        // Título da tarefa, inicializado com string vazia para evitar valores nulos
        public string Title { get; set; } = string.Empty;
        
        // Descrição da tarefa
        public string Description { get; set; } = string.Empty;
        
        // Indica se a tarefa está concluída ou não (true ou false)
        public bool IsDone { get; set; }
        
        // Data e hora em que a tarefa foi criada, definida para o momento da instância
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
