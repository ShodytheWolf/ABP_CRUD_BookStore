using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.BooksDTO
{
    public interface IBookAppService : ICrudAppService<
        BookDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDTO>

    {


    }
}
