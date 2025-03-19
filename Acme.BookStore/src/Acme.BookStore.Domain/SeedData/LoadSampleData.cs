using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.SeedData {

    public class LoadSampleData : IDataSeedContributor, ITransientDependency {

        private readonly IRepository<Book, Guid> _bookRepository;

        public LoadSampleData(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }


        //para probar esto, hay que ejecutar el DBMigrator
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0) {
                
                await _bookRepository.InsertAsync(
                    new Book {

                        Name = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 19.84f
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book {

                        Name = "Structure and Interpretation of Computer Programs",
                        Type = BookType.Horror,
                        PublishDate = new DateTime(1996, 9, 27),
                        Price = 0.0f
                    },
                    autoSave: true
                );
            }
        }
    }
}
