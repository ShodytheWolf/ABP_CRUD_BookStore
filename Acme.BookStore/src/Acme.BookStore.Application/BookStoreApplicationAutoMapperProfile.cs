using Acme.BookStore.Books;
using AutoMapper;
using Acme.BookStore.BooksDTO;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //Aqu� basicamente lo que hacemos es mappear un objeto de dominio a un DTO haciendo uso de Automapper.
        CreateMap<Book, BookDTO>();

        //ni idea porqu� creamos un CreateUpdate en vez de hacer una funci�n en el propio DTO.
        //pero hay que mapearla tambi�n, incluido este orden raro.
        CreateMap<CreateUpdateBookDTO, Book>();


    }
}
