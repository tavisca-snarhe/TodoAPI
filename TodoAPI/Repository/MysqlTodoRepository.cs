using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.entities;

namespace TodoAPI.Repository
{
    public class MysqlTodoRepository : ITodoRepository
    {
        private TodoDbContext _context;

        public MysqlTodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _context.Todos.ToList<Todo>();
        }

        public Task<Todo> GetTodoAsync(string id)
        {
            return _context.Todos.FindAsync(id);
        }
    }
}
