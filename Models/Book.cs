using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Momeu_Olivia_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")] //anotare pt titlu
        public string Title { get; set; }


        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]//anotare pt pret
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Publisher Name")]
        public int PublisherID { get; set; }

        [Display(Name = "Publisher Name")]
        public Publisher Publisher { get; set; }

        [Display(Name = "Book Category")]
        public ICollection<BookCategory> BookCategories { get; set; }

        public string TitluAutor { get { return Title + " by " + Author; } }
    }
}
