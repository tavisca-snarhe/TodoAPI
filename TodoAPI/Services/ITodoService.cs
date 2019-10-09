using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.entities;

namespace TodoAPI.Services
{
    public interface ITodoService
    {
        Task<ActionResult<Todo>> GetTodo(string id);
        IEnumerable<Todo> GetTodos();
    }
}