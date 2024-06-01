using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
    public class Writer
    {
        public  int  WriterId { get; set; }
        public  string  Name { get; set; }
        public  string  Description { get; set; }
        public  string  ImageUrl { get; set; }
        public  List<Article> Articles { get; set; }
        public bool EmailConfirm { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Status { get; set; }

    }
}
