using System;
using System.ComponentModel.DataAnnotations;

namespace TodoListforrealthistime.Models
{
    public class TodoListItem
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Title must contain at least two characters!")]
        [MaxLength(100, ErrorMessage = "Title must contain a maximum of 100 characters!")]
        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}