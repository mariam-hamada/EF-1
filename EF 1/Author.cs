using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1
{
    public class Author
    {
        public int AuthorID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
