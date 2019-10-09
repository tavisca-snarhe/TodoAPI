using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAPI.entities;

namespace TodoAPI.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetTodos();
        Task<Todo> GetTodoAsync(string id);
    }
}