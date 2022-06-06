﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    //Depended Entity for Category
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }

        //Foreign Key
        public int? CategoryId { get; set; }

        //simple navigation property
        public Category Category { get; set; }
        //Navigation Property
        public BookDetail BookDetail { get; set; }
        //Collection Navigation Property
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
