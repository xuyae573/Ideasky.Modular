using Ideasky.Domain;
using Ideasky_Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky.Application
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository repository)
        {
            _bookRepository = repository;
        }
        public BookDto Get(int id)
        {
            var result = _bookRepository.Get(id);
            return new BookDto()
            {
                Id = result.Id,
                Name = result.Name
            };
        }
    }
}
