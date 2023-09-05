using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace teste_app
{
    public class ModelClient
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
