using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;

namespace Acme.BookStore.BooksDTO
{
    public class CreateUpdateBookDTO {

        //supuestamente, todo esto lo válida automaticamente ABP
        //https://abp.io/docs/latest/framework/fundamentals/validation
        [Required]
        [StringLength(255)]
        public string? Name { get; set; } = string.Empty;

        [Required]
        public BookType Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; } = 0f;
    }
}
