using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_Xamarin.Models;

namespace Proiect_Xamarin.Data
{
    public class ProjectDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ProjectDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Bilet>().Wait();
            _database.CreateTableAsync<Aeroport>().Wait();
            _database.CreateTableAsync<BoardingPass>().Wait();
            _database.CreateTableAsync<Client>().Wait();
        }

        public Task<List<Bilet>> GetBileteAsync()
        {
            return _database.Table<Bilet>().ToListAsync();
        }

        public Task<Bilet> GetBileteAsync(int id)
        {
            return _database.Table<Bilet>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }

        public Task<int> SaveBiletAsync(Bilet bilet)
        {
            if (bilet.ID != 0)
            {
                return _database.UpdateAsync(bilet);
            }
            else
            {
                return _database.InsertAsync(bilet);
            }
        }

        public Task<int> SaveBoardingPassAsync(BoardingPass bp)
        {
            if (bp.ID != 0)
            {
                return _database.UpdateAsync(bp);
            }
            else
            {
                return _database.InsertAsync(bp);
            }
        }

        public Task<List<BoardingPass>> GetBoardingPassAsync()
        {
            return _database.Table<BoardingPass>().ToListAsync();
        }

        public Task<BoardingPass> GetBoardingPassAsync(int id)
        {
            return _database.Table<BoardingPass>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }

        public Task<int> SaveClientAsync(Client cl)
        {
            if (cl.ID != 0)
            {
                return _database.UpdateAsync(cl);
            }
            else
            {
                return _database.InsertAsync(cl);
            }
        }

        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }

        public Task<List<Client>> GetClientAsync()
        {
            return _database.Table < Client>().ToListAsync();
        }
    }
}
