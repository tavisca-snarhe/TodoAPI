using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoAPI.entities
{
    [Table("todo")]
    public class Todo
    {
        private string v1;
        private string v2;
        private bool v3;

        public Todo(string v1, string v2, bool v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
