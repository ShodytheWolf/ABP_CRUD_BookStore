using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStore.BooksDTO;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Books;

public class EditModalModel : BookStorePageModel
{

    [HiddenInput] //que no se vea en el URL este par�metro
    [BindProperty(SupportsGet = true)] //que se pueda pedir a trav�s del GET
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateBookDTO Book { get; set; }

    private readonly IBookAppService _bookAppService;

    public EditModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }


    public async Task OnGetAsync()
    {
        var bookDto = await _bookAppService.GetAsync(Id);

        //ac� mapeamos el BookDTO que nos devuelve el crud de bookAppService, al DTO de CreateUpdateBookDTO
        Book = ObjectMapper.Map<BookDTO, CreateUpdateBookDTO>(bookDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _bookAppService.UpdateAsync(Id, Book);
        return NoContent();
    }
}
