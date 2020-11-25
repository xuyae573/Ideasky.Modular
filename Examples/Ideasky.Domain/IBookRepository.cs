using System;
using System.Collections.Generic;
using System.Text;

namespace Ideasky.Domain
{
    public interface IBookRepository
    {
        Book Get(int id);
    }
}
