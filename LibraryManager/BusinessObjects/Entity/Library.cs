using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Library : AEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        //public IEnumerable<Book>? Books { get; set; }
    }
}
