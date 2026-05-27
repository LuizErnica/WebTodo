using System.ComponentModel.DataAnnotations;

namespace WebTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string? Title { get; set; }
    }
}
