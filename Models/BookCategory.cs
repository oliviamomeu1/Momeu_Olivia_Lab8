using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Momeu_Olivia_Lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }

      
        public int BookID { get; set; }
        [Display(Name = "Book Title and Author Name")]
        public Book Book { get; set; }

        public int CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public Category Category { get; set; }

    }
}
