using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
    }
}
