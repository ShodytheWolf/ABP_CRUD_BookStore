using Acme.BookStore.BooksDTO;
using AutoMapper;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        
        //este mapeo podr�a est�r en el mapeador del Application, pero dado que solo va a ocurrir en la capa de presentaci�n
        //nos podemos dar el lujo de definirlo aqu�.
        CreateMap<BookDTO, CreateUpdateBookDTO>();
    }
}
