using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    // Definição do nosso contexto de dados, que é como o "coração" da conexão com o banco
    // Ele configura o EF Core para trabalhar com SQLite e mapeia nossas classes para as tabelas
    public class ApplicationDbContext : DbContext
    {
        // O construtor recebe as configurações que precisamos (como a string de conexão e o provedor de banco) e  passa para a classe base do EF Core
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet representa a tabela "TodoItems" no nosso banco.
        // Aqui é onde vamos armazenar e manipular os nossos itens de tarefa (CRUD: Criar, Ler, Atualizar, Excluir)
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
