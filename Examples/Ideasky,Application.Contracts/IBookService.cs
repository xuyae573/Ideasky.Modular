using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky_Application.Contracts
{
    public interface IBookService
    {
        BookDto Get(int id);
    }
}
