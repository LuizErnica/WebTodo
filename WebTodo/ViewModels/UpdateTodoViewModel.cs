using System.ComponentModel.DataAnnotations;

namespace WebTodo.ViewModels
{
    public class UpdateTodoViewModel
    {
        public string? Title { get; set; }
        public bool Done { get; set; }
    }
}
