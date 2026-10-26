using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1
{
    public  class Book
    {
        public int BookID { get; set; }
        public String ISBNNumber { get; set; }
        public String  Title { get; set; }
        public Decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }

    }
}
