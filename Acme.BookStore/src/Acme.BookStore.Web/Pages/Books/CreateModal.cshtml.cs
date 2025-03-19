using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.BooksDTO;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Books
{
    public class CreateModalModel : BookStorePageModel
    {
        [BindProperty]
        public CreateUpdateBookDTO Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        //importante, el código para inicializar el DTO que va a ser usado para crear el libro, está en el OnGet()
        //porqué NET no encuentra necesario hacer instancias particulares de esta página, lo que significa que 
        //los valores predeterminados y cualquier código dentro del constructor no va a correr.
        public void OnGet() {
            Book = new CreateUpdateBookDTO();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
