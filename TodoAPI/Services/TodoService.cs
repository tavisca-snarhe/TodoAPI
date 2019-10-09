using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAPI.entities;
using TodoAPI.Repository;

namespace TodoAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _todoRepository.GetTodos();
        }

        public async Task<ActionResult<Todo>> GetTodo(string id)
        {
            var todo = await _todoRepository.GetTodoAsync(id);
            return todo;
        }
    }
}
