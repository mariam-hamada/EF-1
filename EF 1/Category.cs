using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public bool IsActive { get; set; }

    }
}
