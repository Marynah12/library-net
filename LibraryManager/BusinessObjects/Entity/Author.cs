using System;
namespace BusinessObjects.Entity
{
    public class Author : AEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public IEnumerable<Book>? Books { get; set; }
    }
}

