﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.BooksDTO;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService : CrudAppService<
        Book,
        BookDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateBookDTO>,
        IBookAppService {

        public BookAppService(IRepository<Book, Guid> repository) : base(repository){

        }
    }
}
