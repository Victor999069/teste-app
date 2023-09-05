using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace teste_app
{
    public interface Services
    {
        SQLiteAsyncConnection GetConnectionAsync();
    }
}
