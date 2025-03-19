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

        //importante, el c�digo para inicializar el DTO que va a ser usado para crear el libro, est� en el OnGet()
        //porqu� NET no encuentra necesario hacer instancias particulares de esta p�gina, lo que significa que 
        //los valores predeterminados y cualquier c�digo dentro del constructor no va a correr.
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
