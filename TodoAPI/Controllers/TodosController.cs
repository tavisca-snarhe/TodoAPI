using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.entities;
using TodoAPI.Services;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }
  
        // GET: api/Todos
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetTodos()
        {
            return Ok(_todoService.GetTodos()); 
        }

        // GET: api/Todos/5
        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodo(string id)
        {
            return Ok(_todoService.GetTodo(id));
        }
    }
}
