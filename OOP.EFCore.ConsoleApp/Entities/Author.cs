using System;
using System.Collections.Generic;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>
            string.Concat(FirstName, " ", LastName);
        public DateTime CreatedDate { get; set; }

        //Collection Navigation Property
        public ICollection<BookAuthor> BookAuthors { get; set; }


    }
}
