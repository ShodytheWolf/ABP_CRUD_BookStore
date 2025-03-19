using Acme.BookStore.BooksDTO;
using AutoMapper;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        
        //este mapeo podría estár en el mapeador del Application, pero dado que solo va a ocurrir en la capa de presentación
        //nos podemos dar el lujo de definirlo aquí.
        CreateMap<BookDTO, CreateUpdateBookDTO>();
    }
}
