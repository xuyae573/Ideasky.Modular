using System;

namespace Ideasky.Domain.EntityFrameworkCore
{
    public class BookRepository : IBookRepository
    {
        public Book Get(int id)
        {
            return new Book()
            {
                Id = 123,
                Name = "King Arthur"
            };
        }
    }
}
