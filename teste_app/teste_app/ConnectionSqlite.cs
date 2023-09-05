using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace teste_app
{
    public class ConnectionSqlite
    {
        private readonly SQLiteAsyncConnection _database;

        public ConnectionSqlite()
        {
            var databaseService = DependencyService.Get<Services>();
            _database = databaseService.GetConnectionAsync();
            _database.CreateTableAsync<ModelClient>().Wait();
        }

        public Task<List<ModelClient>> GetClientesAsync()
        {
            return _database.Table<ModelClient>().ToListAsync();
        }

        public Task<int> AddCliente(ModelClient client)
        {
            return _database.InsertAsync(client);
        }
    }
}

