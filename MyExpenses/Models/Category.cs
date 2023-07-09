using System.ComponentModel.DataAnnotations;

namespace MyExpenses.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
    }
}
